using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeChip_CadastrosOfertas.Database.Mapping;
using WeChip_CadastrosOfertas.Database.Seeds;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cliente>(new ClienteMapping().Configure);
            builder.Entity<Status>(new StatusMapping().Configure);
            builder.Entity<Produto>(new ProdutoMapping().Configure);
            builder.Entity<Endereco>(new EnderecoMapping().Configure);
            builder.Entity<Oferta>(new OfertaMapping().Configure);
            builder.Entity<ProdutoOferta>(new ProdutoOfertaMapping().Configure);

            ProdutosSeeds.Produtos(builder);
            StatusSeeds.Status(builder);
        }
    }
}
