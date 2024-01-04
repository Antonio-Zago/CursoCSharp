using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegates
    {

        delegate int Soma(int a, int b);
        delegate void ImprimirConsole(int a, int b);

        public int MinhaSoma(int a, int b)
        {
            return a + b;
        }

        public void MeuImprimirConsole(int a, int b)
        {
            Console.WriteLine(a + b);
        }


        public void Executar()
        {
            //Associando uma função que já existe, com a mesma assinatura a um delegate
            //Não necessariamente tenho que associar uma função anônima
            Soma op1 = MinhaSoma;
        }
    }
}
