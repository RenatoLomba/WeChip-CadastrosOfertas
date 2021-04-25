using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Repository.interfaces
{
    public interface IOfertaRepository : IRepository<Oferta>
    {
        Task<Oferta> OfertaCompleteAPI(Guid id);
        Task<Oferta> OfertaCompleteCpfAPI(string cpf);

        Oferta OfertaComplete(Guid id);
        Oferta PesquisarOfertaPorCliente(string cpf);
    }
}
