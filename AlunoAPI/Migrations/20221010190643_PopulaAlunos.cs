using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    public partial class PopulaAlunos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(1,'Rafael',25,1)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(2,'Lucas',12,2)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(3,'Gustavo',13,3)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(4,'Kowalski',18,1)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(5,'Maria',11,2)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(6,'Joao',15,3)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(7,'Welisson',34,1)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(8,'Lett',23,2)");

            migrationBuilder.Sql("Insert into Alunos(AlunoId,Nome,Idade,SalaId)" +
                "Values(9,'Gaules',35,3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Alunos");
        }
    }
}
