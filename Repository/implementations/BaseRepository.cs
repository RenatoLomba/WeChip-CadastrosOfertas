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
    public class BaseRepository<T> : IRepository<T> where T : Base
    {
        protected readonly MyContext _context;
        protected readonly DbSet<T> _data;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _data = context.Set<T>();
        }

        public T Cadastrar(T item)
        {
            item.Id = Guid.NewGuid();
            item.CreatedAt = DateTime.UtcNow;
            item.UpdatedAt = DateTime.UtcNow;

            this._data.Add(item);
            this._context.SaveChanges();

            return item;
        }

        public T PesquisarPorId(Guid id)
        {
            var item = _data.FirstOrDefault(i => i.Id.Equals(id));
            return item;
        }

        public IEnumerable<T> Todos()
        {
            var results = _data.ToList();
            return results;
        }
    }
}
