using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlunoModel2
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public DateTime Matricula { get; set; }
        public int Faltas { get; set; }

        public AlunoModel2()
        {
            Nome = "Rodrigo";
            Curso = "Desenvolvimento de Sistemas";
            Faltas = 1;
            Matricula = new DateTime(2023,1,27);
        }

        public static AlunoModel2 CriarAluno()
        {
            var aluno = new AlunoModel2();
            aluno.Nome = "Emerson";
            return aluno;
        }
        public static List<AlunoModel2> CriarLista()
        {
            var lista = new List<AlunoModel2>();
           // lista.Add(new AlunoModel2());
           // lista.Add(AlunoModel2.CriarAluno());
           lista.Add(new AlunoModel2() { Nome= "Nicolas", Curso = "DS", Faltas = 5, Matricula = DateTime.Now});
           lista.Add(new AlunoModel2() { Nome= "Emerson", Curso = "DS", Faltas = 5, Matricula = DateTime.Now});
           lista.Add(new AlunoModel2() { Nome= "Ana", Curso = "DS", Faltas = 5, Matricula = DateTime.Now});
           lista.Add(new AlunoModel2() { Nome= "Vinicius", Curso = "DS", Faltas = 5, Matricula = DateTime.Now});

            return lista;
        }
    }
}