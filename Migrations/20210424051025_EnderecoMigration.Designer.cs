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
    [Migration("20210424051025_EnderecoMigration")]
    partial class EnderecoMigration
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
                            Id = new Guid("9905a864-a846-4a79-9881-641a66b2448f"),
                            Codigo = "00015",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 476, DateTimeKind.Utc).AddTicks(7676),
                            Descricao = "Mouse",
                            Preco = 20.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 476, DateTimeKind.Utc).AddTicks(8379)
                        },
                        new
                        {
                            Id = new Guid("b4a1bce3-918a-4058-9afe-a3a183edbd94"),
                            Codigo = "00106",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1421),
                            Descricao = "Teclado",
                            Preco = 30.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1434)
                        },
                        new
                        {
                            Id = new Guid("ddc87f6b-d575-4eab-a0f5-282c11875f59"),
                            Codigo = "00200",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1482),
                            Descricao = "Monitor 17",
                            Preco = 350.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1484)
                        },
                        new
                        {
                            Id = new Guid("8b70e247-8879-464f-b080-65063fd994f1"),
                            Codigo = "00211",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1486),
                            Descricao = "Pen Drive 8GB",
                            Preco = 30.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1487)
                        },
                        new
                        {
                            Id = new Guid("f45ff513-79ef-4b66-9f75-75b6b747cffb"),
                            Codigo = "00314",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1490),
                            Descricao = "Pen Drive 16GB",
                            Preco = 50.0,
                            Tipo = "HARDWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1491)
                        },
                        new
                        {
                            Id = new Guid("0c7a198f-3cc1-4955-9a8e-135ba6c0510d"),
                            Codigo = "00459",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1493),
                            Descricao = "AVAST",
                            Preco = 199.0,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1494)
                        },
                        new
                        {
                            Id = new Guid("ef88ee1a-0600-4601-a146-8f16dd192607"),
                            Codigo = "01104",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1496),
                            Descricao = "Pacote Office",
                            Preco = 499.0,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1497)
                        },
                        new
                        {
                            Id = new Guid("5bbd4dbc-b940-413b-b999-a17a7212e956"),
                            Codigo = "01108",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1512),
                            Descricao = "Spotify (3 meses)",
                            Preco = 45.5,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1513)
                        },
                        new
                        {
                            Id = new Guid("9408bd8d-9683-43ea-b7cb-1ddc9ecd1071"),
                            Codigo = "01107",
                            CreatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1515),
                            Descricao = "Netflix (1 mês)",
                            Preco = 199.0,
                            Tipo = "SOFTWARE",
                            UpdatedAt = new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1516)
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
