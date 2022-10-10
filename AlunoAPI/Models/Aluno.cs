using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AlunoAPI.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [StringLength(50)]
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public int SalaId { get; set; }
        [JsonIgnore]
        public Sala Sala { get; set; }
    }
}
