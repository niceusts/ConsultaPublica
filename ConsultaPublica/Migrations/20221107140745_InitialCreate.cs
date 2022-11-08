using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsultaPublica.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Residencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterferenciaCidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterferenciaComunidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadePoderPublico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confianca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcoesRelevancia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descreva = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
