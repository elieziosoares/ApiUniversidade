using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiUniversidade.Controllers;

[ApiController]
[Route("[controller]")]
public class CursoController : Controller
{
    private readonly ILogger<Curso> _logger;

    public CursoController(ILogger<Curso> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "cursos")]
    public Curso GetCursos()
    {
        Curso curso = new Curso{
            Nome = "Exemplo",
            Area = "Computação",
            Duracao = 6
        };
        
        curso.Disciplinas.Add(new Disciplina{
            Nome = "Programação para Internet",
            CargaHoraria = 60,
            Semestre = 4
        });
        curso.Disciplinas.Add(new Disciplina{
            Nome = "Programação Orientada a Objetos",
            CargaHoraria = 80,
            Semestre = 2
        });
        curso.Disciplinas.Add(new Disciplina{
            Nome = "Desenvolvimento Back-End",
            CargaHoraria = 80,
            Semestre = 4
        });

        
        curso.Alunos.Add(new Aluno{
                Nome = "Joãozinho",
                DataNascimento = new DateTime(2010,01,01),
                Cpf = "123.123.123-12"
        });
        curso.Alunos.Add(new Aluno{
                Nome = "Fulaninho",
                DataNascimento = new DateTime(2008,02,02),
                Cpf = "321.321.321-32"
            });
        curso.Alunos.Add(new Aluno{
                Nome = "Mariazinha",
                DataNascimento = new DateTime(2009,03,03),
                Cpf = "213.213.213-21"
            });

        return curso;
    }
}