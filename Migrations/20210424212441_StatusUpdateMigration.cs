using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeChip_CadastrosOfertas.Migrations
{
    public partial class StatusUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("0257ba8b-8137-45ae-8852-f67c32b002a9"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("43d156be-a43c-4ddf-b2e0-7376fbf9606d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5580afd7-b0aa-426e-9d09-140071ca369e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("82b2f171-41e8-42f3-9763-cd1e16da9293"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("90593b92-2d2f-464e-a591-b9798b07a2fb"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c66134aa-7e00-412d-8983-70b6a409d8a2"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c9ba605b-26fc-4fe6-a4fe-c20475b4fa56"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f593b59f-28ed-42e5-9ea0-c450892a1bbe"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("fbb5ad57-91cf-4fbe-8e59-0cd7c2253ad9"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("23a3fa06-9b9e-4384-8131-1a5143f707cb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("4c3bb60b-c152-41ab-beb5-3c4e7b5c4388"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("caf5424c-6da5-4c7d-a27e-058e1bd36516"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("d7e7fed1-05d0-43e4-a3f4-a96087487e5d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("f56915b0-6b96-4363-a3ae-6f86664f1e8b"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("fe176f66-8a6b-42ad-b3ac-30b2b545510c"));

            migrationBuilder.DropColumn(
                name: "ContabilizaVenda",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FinalizaCliente",
                table: "Clientes");

            migrationBuilder.AddColumn<bool>(
                name: "ContabilizaVenda",
                table: "Status",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FinalizaCliente",
                table: "Status",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("00e350b8-9a97-4e0d-8a66-ea334de32c48"), "00015", new DateTime(2021, 4, 24, 21, 24, 40, 265, DateTimeKind.Utc).AddTicks(9290), "Mouse", 20.0, "HARDWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("715a370c-c626-401a-841b-f4a62d79c238"), "00106", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3557), "Teclado", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("fd295aca-7400-40d0-aec4-72c5084b4643"), "00200", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3632), "Monitor 17", 350.0, "HARDWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("9e2ebbc9-d5b0-47bd-989c-dd34594bd893"), "00211", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3637), "Pen Drive 8GB", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3638) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("aba98d77-a4fc-4750-8874-7fd9e5b7dd59"), "00314", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3640), "Pen Drive 16GB", 50.0, "HARDWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("92404c8a-f4b1-44b4-9819-e265a847283b"), "00459", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3644), "AVAST", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("db0418e7-5082-42a1-b5e2-bee91a550c21"), "01104", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3648), "Pacote Office", 499.0, "SOFTWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("3b949fc7-a15a-4eaa-96c8-12921cacb7d8"), "01108", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3652), "Spotify (3 meses)", 45.5, "SOFTWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("e03ae497-cf07-4be5-ab77-073947a63943"), "01107", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3662), "Netflix (1 mês)", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 21, 24, 40, 266, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("46bfaa6d-9a27-41f8-9fdd-6f32770c41f9"), "0001", false, new DateTime(2021, 4, 24, 21, 24, 40, 268, DateTimeKind.Utc).AddTicks(9293), "Nome Disponível", false, new DateTime(2021, 4, 24, 21, 24, 40, 268, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("bf9fe27a-17ad-48db-9dc9-b756ae67b4a1"), "0007", false, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(615), "Não deseja ser contatado", true, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("a1ce6ed2-3f8c-49e8-bef8-32bd8c2e4265"), "0009", true, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(652), "Cliente aceitou oferta", true, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("0039de23-4e91-4d6a-affa-4f2a52a1bd0e"), "0015", false, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(656), "Caiu a Ligação", false, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("e502a445-930b-4214-83bd-2317f110b43f"), "0019", false, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(659), "Viajou", false, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("446e61fd-be7e-4b41-af02-9af698b84541"), "0021", false, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(662), "Falecido", true, new DateTime(2021, 4, 24, 21, 24, 40, 269, DateTimeKind.Utc).AddTicks(663) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("00e350b8-9a97-4e0d-8a66-ea334de32c48"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3b949fc7-a15a-4eaa-96c8-12921cacb7d8"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("715a370c-c626-401a-841b-f4a62d79c238"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("92404c8a-f4b1-44b4-9819-e265a847283b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9e2ebbc9-d5b0-47bd-989c-dd34594bd893"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aba98d77-a4fc-4750-8874-7fd9e5b7dd59"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("db0418e7-5082-42a1-b5e2-bee91a550c21"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e03ae497-cf07-4be5-ab77-073947a63943"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("fd295aca-7400-40d0-aec4-72c5084b4643"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("0039de23-4e91-4d6a-affa-4f2a52a1bd0e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("446e61fd-be7e-4b41-af02-9af698b84541"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("46bfaa6d-9a27-41f8-9fdd-6f32770c41f9"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("a1ce6ed2-3f8c-49e8-bef8-32bd8c2e4265"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("bf9fe27a-17ad-48db-9dc9-b756ae67b4a1"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("e502a445-930b-4214-83bd-2317f110b43f"));

            migrationBuilder.DropColumn(
                name: "ContabilizaVenda",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "FinalizaCliente",
                table: "Status");

            migrationBuilder.AddColumn<bool>(
                name: "ContabilizaVenda",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FinalizaCliente",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("c9ba605b-26fc-4fe6-a4fe-c20475b4fa56"), "00015", new DateTime(2021, 4, 24, 15, 29, 31, 150, DateTimeKind.Utc).AddTicks(7244), "Mouse", 20.0, "HARDWARE", new DateTime(2021, 4, 24, 15, 29, 31, 150, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("82b2f171-41e8-42f3-9763-cd1e16da9293"), "00106", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1749), "Teclado", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("fbb5ad57-91cf-4fbe-8e59-0cd7c2253ad9"), "00200", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1820), "Monitor 17", 350.0, "HARDWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("5580afd7-b0aa-426e-9d09-140071ca369e"), "00211", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1825), "Pen Drive 8GB", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("0257ba8b-8137-45ae-8852-f67c32b002a9"), "00314", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1828), "Pen Drive 16GB", 50.0, "HARDWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("f593b59f-28ed-42e5-9ea0-c450892a1bbe"), "00459", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1832), "AVAST", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("c66134aa-7e00-412d-8983-70b6a409d8a2"), "01104", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1835), "Pacote Office", 499.0, "SOFTWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("90593b92-2d2f-464e-a591-b9798b07a2fb"), "01108", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1839), "Spotify (3 meses)", 45.5, "SOFTWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("43d156be-a43c-4ddf-b2e0-7376fbf9606d"), "01107", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1850), "Netflix (1 mês)", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 15, 29, 31, 151, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("f56915b0-6b96-4363-a3ae-6f86664f1e8b"), "0001", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7858), "Nome Disponível", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("fe176f66-8a6b-42ad-b3ac-30b2b545510c"), "0007", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7932), "Não deseja ser contatado", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("4c3bb60b-c152-41ab-beb5-3c4e7b5c4388"), "0009", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7936), "Cliente aceitou oferta", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("d7e7fed1-05d0-43e4-a3f4-a96087487e5d"), "0015", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7940), "Caiu a Ligação", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("23a3fa06-9b9e-4384-8131-1a5143f707cb"), "0019", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7943), "Viajou", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("caf5424c-6da5-4c7d-a27e-058e1bd36516"), "0021", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7946), "Falecido", new DateTime(2021, 4, 24, 15, 29, 31, 153, DateTimeKind.Utc).AddTicks(7947) });
        }
    }
}
