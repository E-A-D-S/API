using System.Collections.Generic;
namespace EscolaApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public List<AlunoCurso> AlunosCursos { get; set; }

    }
}
