using Microsoft.EntityFrameworkCore.Migrations;

namespace apiVendas.Migrations
{
    public partial class Venda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    IdVenda = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroPedido = table.Column<long>(type: "INTEGER", nullable: false),
                    Cliente = table.Column<int>(type: "INTEGER", nullable: false),
                    Vendedor = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<long>(type: "INTEGER", nullable: false),
                    Produto = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ValorTotal = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.IdVenda);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venda");
        }
    }
}
