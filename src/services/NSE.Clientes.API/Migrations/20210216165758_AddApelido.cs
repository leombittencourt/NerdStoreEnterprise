using Microsoft.EntityFrameworkCore.Migrations;

namespace NSE.Clientes.API.Migrations
{
    public partial class AddApelido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Clientes",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Clientes");
        }
    }
}
