using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUniversidade.Model;
public class Disciplina
{
    public int Id{get; set;}
    public string? Nome{get; set;}
    public int CargaHoraria{get; set;}
    public int Semestre{get; set;}

    public int CursoId { get; set; }
}


