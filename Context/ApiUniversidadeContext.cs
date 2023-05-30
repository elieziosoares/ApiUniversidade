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
}

