using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeChip_CadastrosOfertas.Entities;
using WeChip_CadastrosOfertas.Models;
using WeChip_CadastrosOfertas.Repository;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChip_CadastrosOfertas.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IStatusRepository _statusRepository;

        public ClienteController(IClienteRepository clienteRepository, IStatusRepository statusRepository)
        {
            _clienteRepository = clienteRepository;
            _statusRepository = statusRepository;
        }

        #region VISUALIZAÇÃO
        public IActionResult Index()
        {
            // REALIZA UMA REQUISIÇÃO AO REPOSITÓRIO DE CLIENTES PARA RETORNAR TODOS
            var clientes = _clienteRepository.TodosNaoFinalizados();

            // CONVERTE OS CLIENTES DO BANCO PARA VIEWMODEL
            var clientesTela = clientes.Count() > 0 ? clientes.Select(r => new ClienteViewModel
            {
                Cpf = r.Cpf,
                Credito = r.Credito,
                Nome = r.Nome,
                Telefone = r.Telefone
            }) : new List<ClienteViewModel>();
            return View("Index", clientesTela);
        }
        public IActionResult Pesquisar(ClienteViewModel cliente)
        {
            try
            {
                // PESQUISA UM CLIENTE PELO NOME E/OU CPF
                var clientes = _clienteRepository.Pesquisar(cliente.Cpf, cliente.Nome);
                var clientesTela = clientes.Count() > 0 ? clientes.Select(r => new ClienteViewModel
                {
                    Cpf = r.Cpf,
                    Credito = r.Credito,
                    Nome = r.Nome,
                    Telefone = r.Telefone
                }) : new List<ClienteViewModel>();
                return View("Index", clientesTela);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.InnerException.Message;
                return View("Cadastrar");
            }
        }
        #endregion

        #region CADASTRO
        public IActionResult Cadastrar()
        {
            ViewBag.Action = "CadastrarCliente";
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCliente(ClienteViewModel cliente)
        {
            try
            {
                // VALIDA OS CAMPOS DE CLIENTE
                if (!ValidateCliente(cliente))
                {
                    return View("Cadastrar");
                }

                // CRIA UMA ENTIDADE DE CLIENTE PARA SER SALVA NO BANCO, COM O STATUS NOME DISPONÍVEL (TABELA STATUS)
                var newCliente = new Cliente
                {
                    Nome = cliente.Nome,
                    Cpf = cliente.Cpf.Trim().Replace(".", "").Replace("/", ""),
                    Telefone = cliente.Telefone,
                    Credito = cliente.Credito,
                    StatusId = Guid.Parse("33B5A200-0C8F-4F2B-972E-5D0E1F74FDFB"),
                };

                // REALIZA UMA REQUISIÇÃO AO REPOSITÓRIO DA TABELA PARA CADASTRAR O CLIENTE
                var clienteCreated = this._clienteRepository.Cadastrar(newCliente);

                return this.Index();
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.InnerException.Message;
                return View("Cadastrar");
            }
        }
        #endregion

        #region EDITAR
        public IActionResult Editar(string cpf)
        {
            var cliente = _clienteRepository.Pesquisar(cpf).FirstOrDefault();
            var clienteTela = cliente != null ? new ClienteViewModel
            {
                Cpf = cliente.Cpf,
                Credito = cliente.Credito,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            } : new ClienteViewModel();
            ViewBag.Action = "EditarCliente";
            return View(clienteTela);
        }

        public IActionResult EditarCliente(ClienteViewModel cliente)
        {
            try
            {
                // VALIDA NOVAMENTE SE OS CAMPOS ESTÃO PREENCHIDOS CORRETAMENTE
                if (!ValidateCliente(cliente))
                {
                    return View("Cadastrar");
                }

                var newCliente = new Cliente
                {
                    Nome = cliente.Nome,
                    Cpf = cliente.Cpf,
                    Telefone = cliente.Telefone,
                    Credito = cliente.Credito
                };

                // REALIZA UMA REQUISIÇÃO PARA O REPOSITÓRIO ATUALIZAR O CLIENTE
                var updatedCliente = this._clienteRepository.Editar(newCliente);
                ViewBag.Success = "Cliente editado com sucesso";
                return View("Editar", cliente);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.InnerException.Message;
                return View("Editar", cliente);
            }
        }
        #endregion

        #region DELETAR
        public IActionResult Deletar(string cpf)
        {
            try
            {
                // DELETA UM CLIENTE EXISTENTE
                var result = _clienteRepository.Deletar(cpf);
                if (result)
                {
                    ViewBag.Success = "Cliente deletado com sucesso";
                } else
                {
                    ViewBag.Error = "Cliente não encotrado ao deletar";
                }
                return this.Index();
            } catch(Exception ex)
            {
                ViewBag.Error = ex.InnerException.Message;
                return this.Index();
            }
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
        #endregion
    }
}
