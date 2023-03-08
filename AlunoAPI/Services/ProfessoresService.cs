using AlunoAPI.Data;
using AlunoAPI.Interfaces;
using AlunoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunoAPI.Services
{
    public class ProfessoresService : IProfessores
    {
        private readonly AlunoDbContext _context;

        public ProfessoresService(AlunoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Professor>> GetProfessor()
        {
            return await _context.Professores.ToListAsync();
        }

        public async Task PostProfessor(Professor professor)
        {
            _context.Professores.Add(professor);
            await _context.SaveChangesAsync();
        }
    }
}
