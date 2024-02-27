using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    public partial class adicionandocampomodelaluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Alunos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Alunos");
        }
    }
}
