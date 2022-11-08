using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaPublica.Migrations
{
    public partial class testeVorF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "testeVorF",
                table: "Movie",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testeVorF",
                table: "Movie");
        }
    }
}
