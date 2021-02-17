using Microsoft.EntityFrameworkCore.Migrations;

namespace NSE.Clientes.API.Migrations
{
    public partial class RemoveApelido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Clientes",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
