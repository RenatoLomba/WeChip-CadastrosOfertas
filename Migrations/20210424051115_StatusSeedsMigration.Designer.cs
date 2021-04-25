﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeChip_CadastrosOfertas.Database.Context;

namespace WeChip_CadastrosOfertas.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210424051115_StatusSeedsMigration")]
    partial class StatusSeedsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("WeChip_CadastrosOfertas.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ContabilizaVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<double>("Credito")
                        .HasColumnType("REAL");

                    b.Property<bool>("FinalizaCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("StatusId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WeChip_CadastrosOfertas.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("WeChip_CadastrosOfertas.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45bfb251-44bc-4e69-8ec8-2b563697fda1"),
                            Codigo = "00015",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(4102),
                            Descricao = "Mouse",
                            Preco = 20.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(4873)
                        },
                        new
                        {
                            Id = new Guid("11b5e9a3-5d7b-4d73-958d-2e9244e5a66d"),
                            Codigo = "00106",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8374),
                            Descricao = "Teclado",
                            Preco = 30.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8392)
                        },
                        new
                        {
                            Id = new Guid("a38f1ac0-b75f-4f8d-aa46-c316b0de7ecb"),
                            Codigo = "00200",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8447),
                            Descricao = "Monitor 17",
                            Preco = 350.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8448)
                        },
                        new
                        {
                            Id = new Guid("93a00c5f-1d50-4142-a738-2adfd37c4867"),
                            Codigo = "00211",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8451),
                            Descricao = "Pen Drive 8GB",
                            Preco = 30.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8452)
                        },
                        new
                        {
                            Id = new Guid("65c22d9c-7a76-4458-81fa-04a83d53d59c"),
                            Codigo = "00314",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8467),
                            Descricao = "Pen Drive 16GB",
                            Preco = 50.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8469)
                        },
                        new
                        {
                            Id = new Guid("706544c8-9583-484a-89cf-8f5f05f57957"),
                            Codigo = "00459",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8471),
                            Descricao = "AVAST",
                            Preco = 199.0,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8472)
                        },
                        new
                        {
                            Id = new Guid("b85b3af5-d97a-42eb-9564-93af6075a31d"),
                            Codigo = "01104",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8475),
                            Descricao = "Pacote Office",
                            Preco = 499.0,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8476)
                        },
                        new
                        {
                            Id = new Guid("3d116f6b-2d5b-4dac-a18b-8b1ac87b1090"),
                            Codigo = "01108",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8478),
                            Descricao = "Spotify (3 meses)",
                            Preco = 45.5,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8479)
                        },
                        new
                        {
                            Id = new Guid("c496bc4f-7e2f-4cdb-be92-7d456593eb5e"),
                            Codigo = "01107",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8481),
                            Descricao = "Netflix (1 mês)",
                            Preco = 199.0,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8482)
                        });
                });

            modelBuilder.Entity("WeChip_CadastrosOfertas.Entities.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = new Guid("476b6aac-1229-4900-89ca-6b5d9796a414"),
                            Codigo = "0001",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5457),
                            Descricao = "Nome Disponível",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5474)
                        },
                        new
                        {
                            Id = new Guid("91fbba28-6d34-4acc-a5d5-e64546a29c6f"),
                            Codigo = "0007",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5523),
                            Descricao = "Não deseja ser contatado",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5525)
                        },
                        new
                        {
                            Id = new Guid("2f71df64-3427-4464-bfb7-271cd05d118c"),
                            Codigo = "0009",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5527),
                            Descricao = "Cliente aceitou oferta",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5528)
                        },
                        new
                        {
                            Id = new Guid("deb03297-c7bb-42f1-bce8-d07f532e572d"),
                            Codigo = "0015",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5543),
                            Descricao = "Caiu a Ligação",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5544)
                        },
                        new
                        {
                            Id = new Guid("e2c35fed-defa-4490-af6c-32037ecb1ee2"),
                            Codigo = "0019",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5546),
                            Descricao = "Viajou",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5547)
                        },
                        new
                        {
                            Id = new Guid("0006181f-afc2-4864-861a-18950d84b950"),
                            Codigo = "0021",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5549),
                            Descricao = "Falecido",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5550)
                        });
                });

            modelBuilder.Entity("WeChip_CadastrosOfertas.Entities.Cliente", b =>
                {
                    b.HasOne("WeChip_CadastrosOfertas.Entities.Status", "Status")
                        .WithMany("Clientes")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("WeChip_CadastrosOfertas.Entities.Status", b =>
                {
                    b.Navigation("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
