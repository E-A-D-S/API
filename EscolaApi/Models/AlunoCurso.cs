﻿namespace EscolaApi.Models
{
    public class AlunoCurso
    {
        public int AlunoId { get; set; }
        public int CursoId { get; set; }

        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
    }
}
