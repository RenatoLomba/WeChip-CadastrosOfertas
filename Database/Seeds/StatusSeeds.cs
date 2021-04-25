using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Seeds
{
    public class StatusSeeds
    {
        public static void Status(ModelBuilder builder)
        {
            builder.Entity<Status>().HasData(
                new Status
                {
                    Descricao = "Nome Disponível",
                    Codigo = "0001",
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ContabilizaVenda = false,
                    FinalizaCliente = false
                },
                new Status
                {
                    Descricao = "Não deseja ser contatado",
                    Codigo = "0007",
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ContabilizaVenda = false,
                    FinalizaCliente = true
                },
                new Status
                {
                    Descricao = "Cliente aceitou oferta",
                    Codigo = "0009",
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ContabilizaVenda = true,
                    FinalizaCliente = true
                },
                new Status
                {
                    Descricao = "Caiu a Ligação",
                    Codigo = "0015",
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ContabilizaVenda = false,
                    FinalizaCliente = false
                },
                new Status
                {
                    Descricao = "Viajou",
                    Codigo = "0019",
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ContabilizaVenda = false,
                    FinalizaCliente = false
                },
                new Status
                {
                    Descricao = "Falecido",
                    Codigo = "0021",
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ContabilizaVenda = false,
                    FinalizaCliente = true
                }
            );
        }
    }
}
