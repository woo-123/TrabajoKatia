using Microsoft.EntityFrameworkCore.Migrations;

namespace GrupoPrueba2.Migrations
{
    public partial class t_pedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "t_proforma",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "t_proforma");
        }
    }
}
