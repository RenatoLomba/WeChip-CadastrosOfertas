using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeChip_CadastrosOfertas.Migrations
{
    public partial class EnderecoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_Clientes_ClienteId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_ClienteId",
                table: "Status");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("07b7674e-d493-4e45-9b3e-5edd1ef52fef"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("40d4ea46-03de-47e6-a558-e5e2ce60da6b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("6360d4f1-4123-48c0-ba53-810b1b3b3673"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("6ee8d449-f0a0-4296-a6c5-d66958b84bf9"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("78e09f7e-9b29-4973-bc29-85f7c0add936"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8774af8f-1b9a-49ea-87e4-05a03ce2b187"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a313a41e-b3c3-444a-a480-022b5e1c8635"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b7ca767c-3280-4741-b84e-b526ad245074"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c90e79c4-02df-431e-a5b1-1fc3f15c88f1"));

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Status");

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

            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CEP = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Rua = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Complemento = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Bairro = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UF = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_StatusId",
                table: "Clientes",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Status_StatusId",
                table: "Clientes",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Status_StatusId",
                table: "Clientes");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_StatusId",
                table: "Clientes");

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

            migrationBuilder.DropColumn(
                name: "ContabilizaVenda",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "FinalizaCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Clientes");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Status",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                values: new object[] { new Guid("b7ca767c-3280-4741-b84e-b526ad245074"), "00015", new DateTime(2021, 4, 24, 4, 26, 32, 944, DateTimeKind.Utc).AddTicks(8803), "Mouse", 20.0, "HARDWARE", new DateTime(2021, 4, 24, 4, 26, 32, 944, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("78e09f7e-9b29-4973-bc29-85f7c0add936"), "00106", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3198), "Teclado", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("07b7674e-d493-4e45-9b3e-5edd1ef52fef"), "00200", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3271), "Monitor 17", 350.0, "HARDWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("40d4ea46-03de-47e6-a558-e5e2ce60da6b"), "00211", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3275), "Pen Drive 8GB", 30.0, "HARDWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("a313a41e-b3c3-444a-a480-022b5e1c8635"), "00314", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3279), "Pen Drive 16GB", 50.0, "HARDWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("6360d4f1-4123-48c0-ba53-810b1b3b3673"), "00459", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3297), "AVAST", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("6ee8d449-f0a0-4296-a6c5-d66958b84bf9"), "01104", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3301), "Pacote Office", 499.0, "SOFTWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("8774af8f-1b9a-49ea-87e4-05a03ce2b187"), "01108", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3305), "Spotify (3 meses)", 45.5, "SOFTWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Codigo", "CreatedAt", "Descricao", "Preco", "Tipo", "UpdatedAt" },
                values: new object[] { new Guid("c90e79c4-02df-431e-a5b1-1fc3f15c88f1"), "01107", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3308), "Netflix (1 mês)", 199.0, "SOFTWARE", new DateTime(2021, 4, 24, 4, 26, 32, 945, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.CreateIndex(
                name: "IX_Status_ClienteId",
                table: "Status",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Clientes_ClienteId",
                table: "Status",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
