using AlunoAPI.Models;

namespace AlunoAPI.Interfaces
{
    public interface ISala
    {
        Task<IEnumerable<Sala>> GetSalas();
        Task<Sala> GetSalaById(int id);
        Task PostSala(Sala sala);
        Task DeleteSala(int id);
    }
}
