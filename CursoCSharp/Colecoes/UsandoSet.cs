using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoSet
    {
        public void Executar()
        {
            var carrinho = new HashSet<string>();
            var teste = "teste";
            carrinho.Add(teste);
            Console.WriteLine(carrinho.Count());
            carrinho.Add(teste);
            //Não aceita adição de elementos repetidos
           Console.WriteLine( carrinho.Count());
        }
    }
}
