using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");
            builder.HasKey(c => c.Id);
            // builder.HasIndex(c => c.).IsUnique();

            builder.Property(c => c.Bairro).IsRequired().HasMaxLength(200);
            builder.Property(c => c.CEP).IsRequired().HasMaxLength(8);
            builder.Property(c => c.Cidade).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Complemento).HasMaxLength(200);
            builder.Property(c => c.Numero).IsRequired();
            builder.Property(c => c.Rua).IsRequired().HasMaxLength(200);
            builder.Property(c => c.UF).IsRequired().HasMaxLength(2);
        }
    }
}
