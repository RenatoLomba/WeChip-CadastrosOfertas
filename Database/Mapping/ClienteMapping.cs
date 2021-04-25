using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Cpf).IsUnique();

            builder.Property(c => c.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Telefone).IsRequired().HasMaxLength(20);
            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.UpdatedAt).IsRequired();
            builder.Property(c => c.StatusId).IsRequired();

            builder.HasOne(c => c.Status).WithMany(s => s.Clientes);
        }
    }
}
