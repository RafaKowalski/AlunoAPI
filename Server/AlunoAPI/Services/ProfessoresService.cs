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

        public async Task<IEnumerable<Professor>> GetProfessores()
        {
            return await _context.Professores.ToListAsync();
        }
        public async Task<Professor> GetProfessorById(int id)
        {
            return await _context.Professores.FindAsync(id);
        }

        public async Task PostProfessor(Professor professor)
        {
            _context.Professores.Add(professor);
            await _context.SaveChangesAsync();
        }

        public async Task PutProfessor(int id, Professor professor)
        {
            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(id))
                {
                    throw new Exception("id de professor não existe");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task DeleteProfessor(int id)
        {
            var professor = await _context.Professores.FindAsync(id);
            if (professor == null)
                throw new Exception("Professor não existe");

            _context.Professores.Remove(professor);
            await _context.SaveChangesAsync();
        }

        private bool ProfessorExists(int id)
        {
            return _context.Professores.Any(e => e.ProfessorId == id);
        }
    }
}
