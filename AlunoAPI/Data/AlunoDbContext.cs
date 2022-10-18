using AlunoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunoAPI.Data
{
    public class AlunoDbContext : DbContext
    {
        public AlunoDbContext (DbContextOptions<AlunoDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno>? Alunos { get; set; }
        public DbSet<Sala>? Sala { get; set; }
        public DbSet<Professor>? Professores { get; set; }
    }
}
