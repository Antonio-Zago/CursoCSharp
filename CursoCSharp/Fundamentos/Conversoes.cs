using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public void Executar()
        {
            int inteiro = 10;

            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;

            //Perda de informação
            int notaTruncada = (int)nota;

            Console.WriteLine(notaTruncada);

            string idade = "12";

            //Convertendo string para inteiro
            Console.WriteLine(int.Parse(idade));

            Console.WriteLine(Convert.ToInt32(idade));

            string palavra = "123a";

            int numero;

            //Tenta converter string em inteiro e atribui a variavel numero, se não for número a entrada, fica como 0
            int.TryParse(palavra, out numero);
            Console.WriteLine(numero);
        }
    }
}
