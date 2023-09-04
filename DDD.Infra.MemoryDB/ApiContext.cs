using DDD.Domain.Universidade.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace DDD.Infra.MemoryDB
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "UniversidadeDb");

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}