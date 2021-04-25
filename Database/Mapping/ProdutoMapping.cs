using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Codigo).IsUnique();

            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Preco).IsRequired();
            builder.Property(c => c.Tipo).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Codigo).IsRequired().HasMaxLength(5);
        }
    }
}
