using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParametro
    {
        public delegate int Operacao(int a, int b); 

        public int Somar(int a, int b)
        {
            return a + b;
        }


        public void Calculadora(Operacao operacao, int a, int b)
        {
            //Executando a função operacao que passou por parametro dentro da função Calculadora
            Console.WriteLine(operacao(a, b));
        }

        public void Executar()
        {
            Operacao operacao = Somar;
            Calculadora(operacao, 1, 2);

            Operacao operacao2 = (n1,n2) => n1 - n2;
            Calculadora(operacao2, 1, 2);
        }
    }
}
