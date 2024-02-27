using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    public partial class PopulaSala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Sala(Letra) Values('A')");

            migrationBuilder.Sql("Insert into Sala(Letra) Values('B')");

            migrationBuilder.Sql("Insert into Sala(Letra) Values('C')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Sala");
        }
    }
}
