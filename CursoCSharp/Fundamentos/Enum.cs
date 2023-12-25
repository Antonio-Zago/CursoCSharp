using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Enum
    {
        public enum Genero { Acao, Aventura, Comedia};

        public class Filme
        {
            public string Name;
            public Genero GeneroFilme;
        }
        public void Executar()
        {
            int id = (int)Genero.Aventura;

            Filme filme = new Filme();
            filme.Name = "Teste";
            filme.GeneroFilme = Genero.Acao;

            Console.WriteLine(id);
        }
    }
}
