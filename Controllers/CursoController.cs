using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Context;
using apiUniversidade.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiUniversidade.Controllers;

[ApiController]
[Route("[controller]")]
public class CursoController : Controller
{
    private readonly ILogger<CursoController> _logger;
    private readonly ApiUniversidadeContext _context;

    public CursoController(ILogger<CursoController> logger, ApiUniversidadeContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "cursos")]
    public ActionResult<IEnumerable<Curso>> GetCursos()
    {
        var cursos = _context.Cursos.ToList();
        if(cursos is null)
            return NotFound();

        return cursos;
    }
}