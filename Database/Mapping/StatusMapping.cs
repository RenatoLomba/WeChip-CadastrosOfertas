using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Mapping
{
    public class StatusMapping : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Codigo).IsUnique();

            builder.Property(c => c.ContabilizaVenda).IsRequired();
            builder.Property(c => c.FinalizaCliente).IsRequired();
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Codigo).IsRequired().HasMaxLength(4);
        }
    }
}
