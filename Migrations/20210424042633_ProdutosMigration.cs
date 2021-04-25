using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeChip_CadastrosOfertas.Migrations
{
    public partial class ProdutosMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Preco = table.Column<double>(type: "REAL", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Codigo = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

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
                name: "IX_Produtos_Codigo",
                table: "Produtos",
                column: "Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
