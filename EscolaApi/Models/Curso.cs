using System;
using System.Collections.Generic;
namespace EscolaApi.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }
        public List<AlunoCurso> AlunosCursos { get; set; }
    }
}
