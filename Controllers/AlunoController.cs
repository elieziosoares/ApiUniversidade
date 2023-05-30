using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name="alunos")]
        public List<Aluno> GetAlunos(){
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno{
                Nome = "Joãozinho",
                DataNascimento = new DateTime(2010,01,01),
                Cpf = "123.123.123-12"
            });
            alunos.Add(new Aluno{
                Nome = "Fulaninho",
                DataNascimento = new DateTime(2008,02,02),
                Cpf = "321.321.321-32"
            });
            alunos.Add(new Aluno{
                Nome = "Mariazinha",
                DataNascimento = new DateTime(2009,03,03),
                Cpf = "213.213.213-21"
            });
            return alunos;
        }
    }
}