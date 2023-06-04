using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Model;
using Microsoft.EntityFrameworkCore;

namespace apiUniversidade.Context;
public class ApiUniversidadeContext : DbContext
{
    public ApiUniversidadeContext(DbContextOptions options) : base(options){}

    public DbSet<Curso>? Cursos { get; set; }
    public DbSet<Disciplina>? Disciplinas { get; set; }
    public DbSet<Aluno>? Alunos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.LowercaseRelationalTableAndPropertyNames();
    }
}

static class DataContextExtensions
{
    public static void LowercaseRelationalTableAndPropertyNames(this ModelBuilder modelBuilder)
    {
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            entity.SetTableName(entity.GetTableName().ToLowerInvariant());

            foreach (var property in entity.GetProperties())
            {
                property.SetColumnName(property.GetColumnName().ToLowerInvariant());
            }
        }
    }
}

