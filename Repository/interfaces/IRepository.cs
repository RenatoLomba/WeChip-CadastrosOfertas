using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Repository.interfaces
{
    public interface IRepository<T> where T : Base
    {
        T Cadastrar(T item);
        IEnumerable<T> Todos();

        T PesquisarPorId(Guid id);
    }
}
