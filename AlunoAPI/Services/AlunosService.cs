using AlunoAPI.Data;
using AlunoAPI.Interfaces;
using AlunoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunoAPI.Services
{
    public class AlunosService : IAlunos
    {
        private readonly AlunoDbContext _context;

        public AlunosService(AlunoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Aluno>> GetAlunos()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task<Aluno> GetAlunoById(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task PostAluno(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task PutAluno(int id, Aluno aluno)
        {
            _context.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoExists(id))
                {
                    throw new Exception("id de aluno não existe");
                }
                else
                {
                    throw;
                }
            }
        }
        public async Task DeleteAluno(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
                throw new Exception("Aluno não existe");

            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
        }

        private bool AlunoExists(int id)
        {
            return _context.Alunos.Any(e => e.AlunoId == id);
        }
    }
}
