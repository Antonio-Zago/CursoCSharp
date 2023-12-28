using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Dicionario
    {
        public void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(1, "teste1");
            filmes.Add(2, "teste2");

            Console.WriteLine(filmes.ContainsKey(1));
            Console.WriteLine(filmes[1]);
            //Verifica se a chave esta contida no dicionario e não da erro caso não esteja
            Console.WriteLine(filmes.GetValueOrDefault(1));

            Console.WriteLine(filmes.ContainsValue("caca"));

            //Percorrer chave e valor
            foreach (KeyValuePair<int,string> filme in filmes)
            {

            }

            foreach (var filme in filmes)
            {

            }
        }
    }
}
