using AlunoAPI.Data;
using AlunoAPI.Interfaces;
using AlunoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunoAPI.Services
{
    public class SalasService : ISala
    {
        private readonly AlunoDbContext _context;

        public SalasService(AlunoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Sala>> GetSalas()
        {
            return await _context.Sala
                .Include(a => a.Alunos)
                .ToListAsync();
        }

        public async Task<Sala> GetSalaById(int id)
        {
            return await _context.Sala.FindAsync(id);
        }

        public async Task PostSala(Sala sala)
        {
            _context.Sala.Add(sala);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSala(int id)
        {
            var sala = await _context.Sala.FindAsync(id);
            if (sala == null)
                throw new Exception("Sala não existe");

            _context.Sala.Remove(sala);
            await _context.SaveChangesAsync();
        }
    }
}
