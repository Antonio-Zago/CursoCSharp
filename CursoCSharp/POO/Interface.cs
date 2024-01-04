using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Interface
    {
        public void Executar()
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine( calculadora.ExecutarOperacoes(1,2));
        }
    }

    interface IOperacaoBinaria
    {
        //Métodos de interface são sempre abstratos
        int Operacao(int a, int b);
    }

    class Soma : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Calculadora
    {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria>()
        {
            new Soma(),
            new Subtracao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"{op.GetType().Name} = {op.Operacao(a,b)}" ;
            }
            return resultado;
        }
    }

    class Subtracao : IOperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
}
