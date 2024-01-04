using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public void Executar()
        {
            //Função anonima, armazenada na variavel 
            //Arrow function
            //Action é uma função void
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda no C#");
            };

            algoNoConsole();

            var jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 6);
            };

            Console.WriteLine(jogarDado());

            //Função que recebe um inteiro e retorna uma string
            Func<int, string> conversorHexa = (numero) =>
            {
                return numero.ToString("X");
            };
            var conversorHexa2 = (int numero) =>
            {
                return numero.ToString("X");
            };


            Console.WriteLine(conversorHexa(10));


        }
    }
}
