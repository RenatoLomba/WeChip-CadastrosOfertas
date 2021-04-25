using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeChip_CadastrosOfertas.Migrations
{
    public partial class ComplementoNullMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Enderecos",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("76272d1d-4f8c-4479-b1ad-12ca42e9e137"), "00015", new DateTime(2021, 4, 24, 22, 20, 11, 859, DateTimeKind.Utc).AddTicks(6619), "Mouse", 20.0, "HARDWARE", new DateTime(2021, 4, 24, 22, 20, 11, 859, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("e6f44416-e02c-4018-821b-0c9195f22600"), "00106", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1031), "Teclado", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("1b96c4ce-9774-4e8b-a3eb-9aa341958737"), "00200", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1102), "Monitor 17", 350.0, "HARDWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1104) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("07bdfafa-c0ee-48d5-b577-334267217cbb"), "00211", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1106), "Pen Drive 8GB", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("9321770c-7577-496b-819a-b4b1185c2b9c"), "00314", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1122), "Pen Drive 16GB", 50.0, "HARDWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("8e476872-6ce9-4584-9332-8e599a202432"), "00459", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1126), "AVAST", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("fd73afb2-f5ca-4a15-b21c-4f38856f20e6"), "01104", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1129), "Pacote Office", 499.0, "SOFTWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("8bff60fb-5fe2-4089-957d-cae46b4e957e"), "01108", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1133), "Spotify (3 meses)", 45.5, "SOFTWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("e0f7d124-481e-4add-ac2a-9d9994618735"), "01107", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1136), "Netflix (1 mês)", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 22, 20, 11, 860, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("33b5a200-0c8f-4f2b-972e-5d0e1f74fdfb"), "0001", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(6699), "Nome Disponível", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("069e5cdb-5bf1-4fde-a678-841d29f2710b"), "0007", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8063), "Não deseja ser contatado", true, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("b962c6c6-f971-421e-8aeb-58d8dd91a0f7"), "0009", true, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8103), "Cliente aceitou oferta", true, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("a0cf8e99-3405-4ec3-9fbb-c436b6ffefb1"), "0015", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8116), "Caiu a Ligação", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("f1e219a5-4444-4556-93e9-c40f8004c528"), "0019", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8119), "Viajou", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "ContabilizaVenda", "CreatedAt", "Descricao", "FinalizaCliente", "UpdatedAt" },
                values: new object[] { new Guid("504a7af2-9b6e-46e2-b96c-cb8643da5d83"), "0021", false, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8123), "Falecido", true, new DateTime(2021, 4, 24, 22, 20, 11, 862, DateTimeKind.Utc).AddTicks(8124) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("07bdfafa-c0ee-48d5-b577-334267217cbb"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1b96c4ce-9774-4e8b-a3eb-9aa341958737"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("76272d1d-4f8c-4479-b1ad-12ca42e9e137"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8bff60fb-5fe2-4089-957d-cae46b4e957e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8e476872-6ce9-4584-9332-8e599a202432"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9321770c-7577-496b-819a-b4b1185c2b9c"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e0f7d124-481e-4add-ac2a-9d9994618735"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e6f44416-e02c-4018-821b-0c9195f22600"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("fd73afb2-f5ca-4a15-b21c-4f38856f20e6"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("069e5cdb-5bf1-4fde-a678-841d29f2710b"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("33b5a200-0c8f-4f2b-972e-5d0e1f74fdfb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("504a7af2-9b6e-46e2-b96c-cb8643da5d83"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("a0cf8e99-3405-4ec3-9fbb-c436b6ffefb1"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("b962c6c6-f971-421e-8aeb-58d8dd91a0f7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("f1e219a5-4444-4556-93e9-c40f8004c528"));

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Enderecos",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);

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
    }
}
