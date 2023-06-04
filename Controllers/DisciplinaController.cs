using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Context;
using apiUniversidade.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiUniversidade.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplinaController : ControllerBase
{
    private readonly ILogger<DisciplinaController> _logger;
    private readonly ApiUniversidadeContext _context;

    public DisciplinaController(ILogger<DisciplinaController> logger, ApiUniversidadeContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "disciplinas")]
    public ActionResult<IEnumerable<Disciplina>> GetDisciplinas()
    {
        var disciplinas = _context.Disciplinas.ToList();
        if(disciplinas is null)
            return NotFound();

        return disciplinas;
    }
}



