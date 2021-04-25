using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeChip_CadastrosOfertas.Entities;

namespace WeChip_CadastrosOfertas.Database.Seeds
{
    public class ProdutosSeeds
    {
        public static void Produtos(ModelBuilder builder)
        {
            builder.Entity<Produto>().HasData(
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "00015",
                    Descricao = "Mouse",
                    Preco = 20.00,
                    Tipo = "HARDWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "00106",
                    Descricao = "Teclado",
                    Preco = 30.00,
                    Tipo = "HARDWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "00200",
                    Descricao = "Monitor 17",
                    Preco = 350.00,
                    Tipo = "HARDWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "00211",
                    Descricao = "Pen Drive 8GB",
                    Preco = 30.00,
                    Tipo = "HARDWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "00314",
                    Descricao = "Pen Drive 16GB",
                    Preco = 50.00,
                    Tipo = "HARDWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "00459",
                    Descricao = "AVAST",
                    Preco = 199.00,
                    Tipo = "SOFTWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "01104",
                    Descricao = "Pacote Office",
                    Preco = 499.00,
                    Tipo = "SOFTWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "01108",
                    Descricao = "Spotify (3 meses)",
                    Preco = 45.50,
                    Tipo = "SOFTWARE"
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Codigo = "01107",
                    Descricao = "Netflix (1 mês)",
                    Preco = 199.00,
                    Tipo = "SOFTWARE"
                }
                );
        }
    }
}
