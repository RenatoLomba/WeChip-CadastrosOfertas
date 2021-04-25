using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Mapping
{
    public class OfertaMapping : IEntityTypeConfiguration<Oferta>
    {
        public void Configure(EntityTypeBuilder<Oferta> builder)
        {
            builder.ToTable("Ofertas");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.ClienteId).IsRequired();
            builder.Property(o => o.EnderecoId).IsRequired();

            builder.HasOne(o => o.Cliente).WithMany(c => c.Ofertas);
            builder.HasOne(o => o.Endereco).WithOne(c => c.Oferta);
        }
    }
}
