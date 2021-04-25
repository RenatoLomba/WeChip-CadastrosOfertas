using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip_CadastrosOfertas.Entities;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChip_CadastrosOfertas.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> TodosNaoFinalizados();
        IEnumerable<Cliente> Pesquisar(string cpf = "", string nome = "");
        Cliente ClienteOferta(string cpf);
        Cliente Editar(Cliente cliente);
        bool Deletar(string cpf);
    }
}
