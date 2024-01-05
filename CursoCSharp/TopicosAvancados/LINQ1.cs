using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ1
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
            //Passa uma arrow function como parametro
            var aprovados = alunos.Where(a => a.Nota>6).OrderBy(a => a.Nome);

            //Estou fazendo um mapping de uma lista de objetos Aluno para uma lista de string
            var teste = alunos.Select(a => a.Nome).OrderBy(a => a).ToList();

            //Outra sintaxe LINQ
            var alunosAprovados = 
                from aluno in alunos
                where aluno.Nota == 6
                orderby aluno.Nome
                select aluno.Nome;

            foreach (var a in teste)
            {
                Console.WriteLine(a);
            }


        }
    }

    class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;


    }
}
