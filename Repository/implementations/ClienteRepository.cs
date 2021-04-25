using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeChip_CadastrosOfertas.Database.Context;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Repository.implementations
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MyContext context): base(context)
        {

        }

        public IEnumerable<Cliente> TodosNaoFinalizados()
        {
            var clientes = _data.Include(c => c.Status).Where(c => c.Status.FinalizaCliente.Equals(false)).ToList();
            return clientes;

        }

        public Cliente ClienteOferta(string cpf)
        {
            var cliente = _data
                .Include(c => c.Status)
                .FirstOrDefault(c => c.Cpf.Equals(cpf));
            return cliente;
        }

        public bool Deletar(string cpf)
        {
            var cliente = _data.FirstOrDefault(c => c.Cpf.Equals(cpf));
            if (cliente == null) return false;

            _data.Remove(cliente);
            _context.SaveChanges();
            return true;
        }

        public Cliente Editar(Cliente cliente)
        {
            var clienteData = _data.FirstOrDefault(c => c.Cpf.Equals(cliente.Cpf));
            if (clienteData == null) throw new Exception("Cliente não encontrado");

            cliente.Id = clienteData.Id;
            cliente.UpdatedAt = DateTime.UtcNow;
            cliente.CreatedAt = clienteData.CreatedAt;

            _context.Entry(clienteData).CurrentValues.SetValues(cliente);
            _context.SaveChanges();

            return cliente;
        }

        public IEnumerable<Cliente> Pesquisar(string cpf = "", string nome = "")
        {
            var clientes = _data.Include(c => c.Status).Where(c => c.Cpf.Equals(cpf) || c.Nome.Equals(nome) && c.Status.FinalizaCliente.Equals(false)).ToList();
            return clientes;
        }
    }
}
