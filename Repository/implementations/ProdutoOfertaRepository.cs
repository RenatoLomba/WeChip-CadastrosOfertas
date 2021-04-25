using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip_CadastrosOfertas.Database.Context;
using WeChip_CadastrosOfertas.Entities;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChip_CadastrosOfertas.Repository.implementations
{
    public class ProdutoOfertaRepository : BaseRepository<ProdutoOferta>, IProdutoOfertaRepository
    {
        public ProdutoOfertaRepository(MyContext context): base(context)
        {

        }
    }
}
