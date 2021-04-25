using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeChip_CadastrosOfertas.Migrations
{
    public partial class OfertasMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Ofertas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ofertas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ofertas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ofertas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoOferta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OfertaId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoOferta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoOferta_Ofertas_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "Ofertas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoOferta_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_ClienteId",
                table: "Ofertas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ofertas_EnderecoId",
                table: "Ofertas",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoOferta_OfertaId",
                table: "ProdutoOferta",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoOferta_ProdutoId",
                table: "ProdutoOferta",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoOferta");

            migrationBuilder.DropTable(
                name: "Ofertas");

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
    }
}
