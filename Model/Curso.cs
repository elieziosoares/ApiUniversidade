using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUniversidade.Model;
public class Curso
{
    public int Id{get; set;}
    public string? Nome{get; set;}
    public string? Area{get; set;}
    public int Duracao{get; set;}
    public List<Disciplina> Disciplinas{get; set;}
    public List<Aluno> Alunos { get; set; }

    public Curso(){
        Disciplinas = new List<Disciplina>();
        Alunos = new List<Aluno>();
    }
}