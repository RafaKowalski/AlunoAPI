using AlunoAPI.Models;

namespace AlunoAPI.Interfaces
{
    public interface IAlunos
    {
        Task<IEnumerable<Aluno>> GetAlunos();
        Task<Aluno> GetAlunoById(int id);
        Task PostAluno(Aluno aluno);
        Task PutAluno(int id, Aluno aluno);
        Task DeleteAluno(int id);
    }
}
