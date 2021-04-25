using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeChip_CadastrosOfertas.Entities;
using WeChip_CadastrosOfertas.Models;
using WeChip_CadastrosOfertas.Repository;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChip_CadastrosOfertas.Controllers
{
    public class OfertaController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IOfertaRepository _ofertaRepository;
        private readonly IProdutoOfertaRepository _produtoOfertaRepository;

        public OfertaController(
            IClienteRepository clienteRepository, 
            IProdutoRepository produtoRepository, 
            IStatusRepository statusRepository,
            IEnderecoRepository enderecoRepository,
            IOfertaRepository ofertaRepository,
            IProdutoOfertaRepository produtoOfertaRepository
            )
        {
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
            _statusRepository = statusRepository;
            _enderecoRepository = enderecoRepository;
            _ofertaRepository = ofertaRepository;
            _produtoOfertaRepository = produtoOfertaRepository;
        }

        #region FORM DE CADASTRO DE OFERTA
        // TELA DE CADASTRO DE OFERTA PARA O CLIENTE
        public IActionResult Index(string cpf)
        {
            try
            {
                // VERIFICAR SE JÁ HOUVE UMA OFERTA PARA ESTE CLIENTE
                var ofertaAlreadyExists = this._ofertaRepository.PesquisarOfertaPorCliente(cpf);
                if(ofertaAlreadyExists != null)
                {
                    return this.Visualizar(ofertaAlreadyExists.Id);
                }

                // REQUISIÇÃO PARA RETORNAR O CLIENTE
                var clienteOferta = _clienteRepository.ClienteOferta(cpf);
                if (clienteOferta == null)
                {
                    ViewBag.Error = "Cliente não encontrado";
                    return View("~/Views/Cliente/Index.cshtml");
                }

                // CRIA UMA VIEW MODEL PARA VISUALIZAÇÃO DO CLIENTE EM TELA
                var clienteViewModel = new ClienteOfertaViewModel
                {
                    Cpf = clienteOferta.Cpf,
                    Credito = clienteOferta.Credito,
                    Nome = clienteOferta.Nome,
                    Status = new StatusViewModel
                    {
                        Id = clienteOferta.Status.Id,
                        Codigo = clienteOferta.Status.Codigo,
                        Descricao = clienteOferta.Status.Descricao,
                        FinalizaCliente = clienteOferta.Status.FinalizaCliente,
                        ContabilizaVenda = clienteOferta.Status.ContabilizaVenda
                    },
                    StatusId = clienteOferta.StatusId,
                    Telefone = clienteOferta.Telefone
                };

                // RETORNA LISTA DE PRODUTOS PARA SELEÇÃO
                var produtos = _produtoRepository.Todos().Select(p => new ProdutoOfertaViewModel
                {
                    Codigo = p.Codigo,
                    Descricao = p.Descricao,
                    Id = p.Id,
                    IsSelected = false,
                    Preco = p.Preco,
                    Tipo = p.Tipo
                });

                // RETORNA TABELA DE STATUS PARA MODIFICAÇÃO
                var statusList = _statusRepository.Todos().Select(s => new StatusViewModel
                {
                    Codigo = s.Codigo,
                    Descricao = s.Descricao,
                    Id = s.Id
                });

                // DADOS DE OFERTA PARA VISUALIZAÇÃO E EDIÇÃO EM TELA
                var ofertaViewModel = new OfertaViewModel
                {
                    Cliente = clienteViewModel,
                    Endereco = new EnderecoViewModel(),
                    Produtos = produtos,
                    StatusList = statusList
                };

                ViewBag.Action = "CadastrarOferta";
                return View("Index", ofertaViewModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.InnerException.Message;
                return View("~/Views/Cliente/Index.cshtml");
            }
        }
        #endregion

        #region CADASTRO
        [HttpPost]
        public IActionResult CadastrarOferta(OfertaViewModel oferta)
        {
            try
            {
                // VALIDAÇÕES NECESSÁRIAS DE CAMPOS E REGRA DE NEGÓCIO
                if (!this.ValidateCliente(oferta.Cliente)) return this.Index(oferta.Cliente.Cpf);
                if (!this.ValidateEndereco(oferta.Endereco, oferta.Produtos)) return this.Index(oferta.Cliente.Cpf);
                if (!this.ValidateProdutos(oferta.Produtos, oferta.Cliente.StatusId, oferta.Cliente.Credito)) return this.Index(oferta.Cliente.Cpf);

                // UPDATE DO CLIENTE
                var newCliente = new Cliente
                {
                    Nome = oferta.Cliente.Nome,
                    Cpf = oferta.Cliente.Cpf.Replace(".", "").Replace("-", "").Trim(),
                    Telefone = oferta.Cliente.Telefone,
                    StatusId = oferta.Cliente.StatusId,
                    Credito = oferta.Cliente.Credito
                };
                var clienteUpdated = this._clienteRepository.Editar(newCliente);

                // CRIA UM ENDERECO NO BANCO
                var newEndereco = new Endereco
                {
                    Bairro = oferta.Endereco.Bairro,
                    CEP = oferta.Endereco.CEP,
                    Cidade = oferta.Endereco.Cidade,
                    Complemento = oferta.Endereco.Complemento,
                    Numero = oferta.Endereco.Numero,
                    Rua = oferta.Endereco.Rua,
                    UF = oferta.Endereco.UF
                };
                var enderecoCreated = this._enderecoRepository.Cadastrar(newEndereco);

                // CRIA UMA OFERTA COM O ENDEREÇO E CLIENTE
                var newOferta = new Oferta
                {
                    ClienteId = clienteUpdated.Id,
                    EnderecoId = enderecoCreated.Id,
                };
                var ofertaCreated = this._ofertaRepository.Cadastrar(newOferta);

                // CADASTRA OS PRODUTOS DA VENDA
                foreach(var produto in oferta.Produtos)
                {
                    if (produto.IsSelected)
                    {
                        var newProduto = new ProdutoOferta
                        {
                            OfertaId = ofertaCreated.Id,
                            ProdutoId = produto.Id
                        };
                        var produtoCreated = this._produtoOfertaRepository.Cadastrar(newProduto);
                    }
                }
                return this.Visualizar(ofertaCreated.Id);
            } catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return this.Index(oferta.Cliente.Cpf);
            }
        }
        #endregion

        #region VISUALIZAR
        public IActionResult Visualizar(Guid id)
        {
            var oferta = this._ofertaRepository.OfertaComplete(id);
            if (oferta == null) ViewBag.Error = "Oferta não encontrada";
            var ofertaViewModel = new OfertaCompleteViewModel
            {
                Id = oferta.Id,
                Cliente = new ClienteOfertaViewModel
                {
                    Cpf = oferta.Cliente.Cpf,
                    Credito = oferta.Cliente.Credito,
                    Nome = oferta.Cliente.Nome,
                    Status = new StatusViewModel
                    {
                        Id = oferta.Cliente.Status.Id,
                        Codigo = oferta.Cliente.Status.Codigo,
                        Descricao = oferta.Cliente.Status.Descricao,
                        FinalizaCliente = oferta.Cliente.Status.FinalizaCliente,
                        ContabilizaVenda = oferta.Cliente.Status.ContabilizaVenda
                    },
                    StatusId = oferta.Cliente.StatusId,
                    Telefone = oferta.Cliente.Telefone
                },
                CreatedAt = oferta.CreatedAt,
                Endereco = new EnderecoViewModel
                {
                    Bairro = oferta.Endereco.Bairro,
                    CEP = oferta.Endereco.CEP,
                    Cidade = oferta.Endereco.Cidade,
                    Complemento = oferta.Endereco.Complemento,
                    Numero = oferta.Endereco.Numero,
                    Rua = oferta.Endereco.Rua,
                    UF = oferta.Endereco.UF
                },
                Produtos = oferta.ProdutosOferta.Select(p => new ProdutoOfertaViewModel {
                    Codigo = p.Produto.Codigo,
                    Descricao = p.Produto.Descricao,
                    Id = p.Produto.Id,
                    Preco = p.Produto.Preco,
                    Tipo = p.Produto.Tipo
                })
            };
            return View("Visualizar", ofertaViewModel);
        }
        #endregion

        #region METODOS AUXILIARES
        public bool ValidateCliente(ClienteViewModel cliente)
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(cliente.Cpf))
            {
                ViewBag.Error = "Cpf vazio";
                isValid = false;
            }
            if (String.IsNullOrEmpty(cliente.Nome))
            {
                ViewBag.Error = "Nome vazio";
                isValid = false;
            }
            if (String.IsNullOrEmpty(cliente.Telefone))
            {
                ViewBag.Error = "Telefone vazio";
                isValid = false;
            }
            return isValid;
        }

        public bool ValidateEndereco(EnderecoViewModel endereco, IEnumerable<ProdutoOfertaViewModel> produtos)
        {
            bool isValid = true;
            bool produtosHaveHardware = false;
            foreach(var produto in produtos)
            {
                produtosHaveHardware = produto.IsSelected && produto.Tipo.Equals("HARDWARE");
            }
            if (produtosHaveHardware && String.IsNullOrEmpty(endereco.Rua))
            {
                ViewBag.Error = "Rua vazia";
                isValid = false;
            }
            if (produtosHaveHardware && String.IsNullOrEmpty(endereco.Bairro))
            {
                ViewBag.Error = "Bairro vazio";
                isValid = false;
            }
            if (produtosHaveHardware && String.IsNullOrEmpty(endereco.CEP))
            {
                ViewBag.Error = "CEP vazio";
                isValid = false;
            }
            if (produtosHaveHardware && String.IsNullOrEmpty(endereco.Cidade))
            {
                ViewBag.Error = "Cidade vazia";
                isValid = false;
            }
            if (produtosHaveHardware && String.IsNullOrEmpty(endereco.UF))
            {
                ViewBag.Error = "Estado vazio";
                isValid = false;
            }

            return isValid;
        }

        public bool ValidateProdutos(IEnumerable<ProdutoOfertaViewModel> produtos, Guid statusId, double creditoCliente)
        {
            bool isValid = true;
            bool haveProduto = false;
            double produtosSum = 0;

            var status = _statusRepository.PesquisarPorId(statusId);

            foreach (var produto in produtos)
            {
                if (produto.IsSelected)
                {
                    produtosSum += produto.Preco;
                    haveProduto = true;
                    break;
                }
            }

            if(haveProduto && produtosSum > creditoCliente)
            {
                isValid = false;
                ViewBag.Error = "Total dos produtos maior que o crédito do cliente";
            }

            if(status.ContabilizaVenda && !haveProduto)
            {
                isValid = false;
                ViewBag.Error = "Selecione um produto para contabilizar a venda";
            }

            if(haveProduto && !status.ContabilizaVenda)
            {
                isValid = false;
                ViewBag.Error = "Foram selecionados produtos, autorize contabilizar venda";
            }

            return isValid;
        }
        #endregion
    }
}
