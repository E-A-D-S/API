using System;
using EscolaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EscolaApi.Dados
{
    public class EscolaApiContext : DbContext
    {
        public EscolaApiContext(DbContextOptions<EscolaApiContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoCurso>()
                .HasKey(ac => new { ac.AlunoId, ac.CursoId });
        }



        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlunoCurso> AlunosCursos { get; set; }

    }
}
