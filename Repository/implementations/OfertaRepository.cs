using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeChip_CadastrosOfertas.Database.Context;
using WeChip_CadastrosOfertas.Entities;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChip_CadastrosOfertas.Repository.implementations
{
    public class OfertaRepository : BaseRepository<Oferta>, IOfertaRepository
    {
        public OfertaRepository(MyContext context): base(context)
        {

        }

        public Oferta OfertaComplete(Guid id)
        {
            var oferta = _data
                .Include(o => o.Cliente).ThenInclude(c => c.Status)
                .Include(o => o.Endereco)
                .Include(o => o.ProdutosOferta).ThenInclude(p => p.Produto)
                .FirstOrDefault(c => c.Id.Equals(id));
            return oferta;
        }

        public async Task<Oferta> OfertaCompleteAPI(Guid id)
        {
            var oferta = await _data
                .Include(o => o.Cliente).ThenInclude(c => c.Status)
                .Include(o => o.Endereco)
                .Include(o => o.ProdutosOferta).ThenInclude(p => p.Produto)
                .FirstOrDefaultAsync(c => c.Id.Equals(id));
            return oferta;
        }

        public async Task<Oferta> OfertaCompleteCpfAPI(string cpf)
        {
            var oferta = await _data
                .Include(o => o.Cliente).ThenInclude(c => c.Status)
                .Include(o => o.Endereco)
                .Include(o => o.ProdutosOferta).ThenInclude(p => p.Produto)
                .FirstOrDefaultAsync(c => c.Cliente.Cpf.Equals(cpf));
            return oferta;
        }

        public Oferta PesquisarOfertaPorCliente(string cpf)
        {
            var oferta = _data.Include(o => o.Cliente).FirstOrDefault(o => o.Cliente.Cpf.Equals(cpf));
            return oferta;
        }
    }
}
