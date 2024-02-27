namespace AlunoAPI.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public char Letra { get; set; }
        public ICollection<Aluno>? Alunos { get; set; }
    }
}
