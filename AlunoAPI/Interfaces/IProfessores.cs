using AlunoAPI.Models;

namespace AlunoAPI.Interfaces
{
    public interface IProfessores
    {
        Task<IEnumerable<Professor>> GetProfessor();
        Task PostProfessor(Professor professor);
    }
}
