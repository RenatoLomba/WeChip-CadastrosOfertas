using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeChip_CadastrosOfertas.Migrations
{
    public partial class StatusSeedsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("0c7a198f-3cc1-4955-9a8e-135ba6c0510d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5bbd4dbc-b940-413b-b999-a17a7212e956"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8b70e247-8879-464f-b080-65063fd994f1"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9408bd8d-9683-43ea-b7cb-1ddc9ecd1071"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9905a864-a846-4a79-9881-641a66b2448f"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b4a1bce3-918a-4058-9afe-a3a183edbd94"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ddc87f6b-d575-4eab-a0f5-282c11875f59"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ef88ee1a-0600-4601-a146-8f16dd192607"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f45ff513-79ef-4b66-9f75-75b6b747cffb"));

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("45bfb251-44bc-4e69-8ec8-2b563697fda1"), "00015", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(4102), "Mouse", 20.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(4873) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("11b5e9a3-5d7b-4d73-958d-2e9244e5a66d"), "00106", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8374), "Teclado", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("a38f1ac0-b75f-4f8d-aa46-c316b0de7ecb"), "00200", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8447), "Monitor 17", 350.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("93a00c5f-1d50-4142-a738-2adfd37c4867"), "00211", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8451), "Pen Drive 8GB", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("65c22d9c-7a76-4458-81fa-04a83d53d59c"), "00314", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8467), "Pen Drive 16GB", 50.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8469) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("706544c8-9583-484a-89cf-8f5f05f57957"), "00459", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8471), "AVAST", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("b85b3af5-d97a-42eb-9564-93af6075a31d"), "01104", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8475), "Pacote Office", 499.0, "SOFTWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("3d116f6b-2d5b-4dac-a18b-8b1ac87b1090"), "01108", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8478), "Spotify (3 meses)", 45.5, "SOFTWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("c496bc4f-7e2f-4cdb-be92-7d456593eb5e"), "01107", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8481), "Netflix (1 mês)", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 5, 11, 15, 284, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("476b6aac-1229-4900-89ca-6b5d9796a414"), "0001", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5457), "Nome Disponível", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("91fbba28-6d34-4acc-a5d5-e64546a29c6f"), "0007", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5523), "Não deseja ser contatado", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("2f71df64-3427-4464-bfb7-271cd05d118c"), "0009", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5527), "Cliente aceitou oferta", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("deb03297-c7bb-42f1-bce8-d07f532e572d"), "0015", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5543), "Caiu a Ligação", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("e2c35fed-defa-4490-af6c-32037ecb1ee2"), "0019", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5546), "Viajou", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "UpdatedAt" },
                values: new object[] { new Guid("0006181f-afc2-4864-861a-18950d84b950"), "0021", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5549), "Falecido", new DateTime(2021, 4, 24, 5, 11, 15, 287, DateTimeKind.Utc).AddTicks(5550) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("11b5e9a3-5d7b-4d73-958d-2e9244e5a66d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3d116f6b-2d5b-4dac-a18b-8b1ac87b1090"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("45bfb251-44bc-4e69-8ec8-2b563697fda1"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("65c22d9c-7a76-4458-81fa-04a83d53d59c"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("706544c8-9583-484a-89cf-8f5f05f57957"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("93a00c5f-1d50-4142-a738-2adfd37c4867"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a38f1ac0-b75f-4f8d-aa46-c316b0de7ecb"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b85b3af5-d97a-42eb-9564-93af6075a31d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c496bc4f-7e2f-4cdb-be92-7d456593eb5e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("0006181f-afc2-4864-861a-18950d84b950"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("2f71df64-3427-4464-bfb7-271cd05d118c"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("476b6aac-1229-4900-89ca-6b5d9796a414"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("91fbba28-6d34-4acc-a5d5-e64546a29c6f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("deb03297-c7bb-42f1-bce8-d07f532e572d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: new Guid("e2c35fed-defa-4490-af6c-32037ecb1ee2"));

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("9905a864-a846-4a79-9881-641a66b2448f"), "00015", new DateTime(2021, 4, 24, 5, 10, 24, 476, DateTimeKind.Utc).AddTicks(7676), "Mouse", 20.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 10, 24, 476, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("b4a1bce3-918a-4058-9afe-a3a183edbd94"), "00106", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1421), "Teclado", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("ddc87f6b-d575-4eab-a0f5-282c11875f59"), "00200", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1482), "Monitor 17", 350.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("8b70e247-8879-464f-b080-65063fd994f1"), "00211", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1486), "Pen Drive 8GB", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("f45ff513-79ef-4b66-9f75-75b6b747cffb"), "00314", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1490), "Pen Drive 16GB", 50.0, "HARDWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("0c7a198f-3cc1-4955-9a8e-135ba6c0510d"), "00459", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1493), "AVAST", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("ef88ee1a-0600-4601-a146-8f16dd192607"), "01104", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1496), "Pacote Office", 499.0, "SOFTWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1497) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("5bbd4dbc-b940-413b-b999-a17a7212e956"), "01108", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1512), "Spotify (3 meses)", 45.5, "SOFTWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("9408bd8d-9683-43ea-b7cb-1ddc9ecd1071"), "01107", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1515), "Netflix (1 mês)", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 5, 10, 24, 477, DateTimeKind.Utc).AddTicks(1516) });
        }
    }
}
