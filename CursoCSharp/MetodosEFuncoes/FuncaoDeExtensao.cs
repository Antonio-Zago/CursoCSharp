using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    
    class FuncaoDeExtensao
    {
        

        public void Executar()
        {
            int numero = 1;

            Console.WriteLine(numero.Somar(2));
            Console.WriteLine(5.Somar(2));

        }
    }

    //Método de extensão com primeiro parametro declarado com a palavra this em uma classe estatica e método estatico
    public static class ExtensaoInteiro
    {
        public static int Somar(this int numA, int numB)
        {
            return numA + numB;
        }
    }
}
