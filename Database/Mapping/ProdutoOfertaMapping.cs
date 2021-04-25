using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Mapping
{
    public class ProdutoOfertaMapping : IEntityTypeConfiguration<ProdutoOferta>
    {
        public void Configure(EntityTypeBuilder<ProdutoOferta> builder)
        {
            builder.ToTable("ProdutoOferta");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.ProdutoId).IsRequired();
            builder.Property(c => c.OfertaId).IsRequired();

            builder.HasOne(c => c.Oferta).WithMany(o => o.ProdutosOferta);
            builder.HasOne(c => c.Produto).WithMany(o => o.ProdutosOferta);
        }
    }
}
