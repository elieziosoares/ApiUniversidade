using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade.Context;
using apiUniversidade.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiUniversidade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly ApiUniversidadeContext _context;

        public AlunoController(ILogger<AlunoController> logger, ApiUniversidadeContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name="alunos")]
        public ActionResult<IEnumerable<Aluno>> GetAlunos(){

            var alunos = _context.Alunos.ToList();
            if(alunos is null)
                return NotFound();

            return alunos;
        }
    }
}