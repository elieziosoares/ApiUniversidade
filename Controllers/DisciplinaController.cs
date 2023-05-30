using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiUniversidade.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplinaController : ControllerBase
{
    private readonly ILogger<Curso> _logger;

    public DisciplinaController(ILogger<Curso> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "disciplinas")]
    public List<Disciplina> GetDisciplinas()
    {
        List<Disciplina> disciplinas = new List<Disciplina>();

        disciplinas.Add(new Disciplina{
            Nome = "Programação para Internet",
            CargaHoraria = 60,
            Semestre = 4
        });
        disciplinas.Add(new Disciplina{
            Nome = "Programação Orientada a Objetos",
            CargaHoraria = 80,
            Semestre = 2
        });
        disciplinas.Add(new Disciplina{
            Nome = "Desenvolvimento Back-End",
            CargaHoraria = 80,
            Semestre = 4
        });
        return disciplinas;
    }
}



