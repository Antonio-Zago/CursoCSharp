using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno(){Nome = "Antonio", Idade = 24, Nota = 10},
                new Aluno(){Nome = "Andre", Idade = 21, Nota =9},
                new Aluno(){Nome = "dasd", Idade = 24, Nota = 1},
                new Aluno(){Nome = "Antonio", Idade = 21, Nota = 6}
            };

            var andre = alunos.Single(a => a.Nome.Equals("Andre"));

            Console.WriteLine(andre.Idade);
        }
    }
}
