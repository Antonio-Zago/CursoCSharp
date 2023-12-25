using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public void Executar()
        {
            var valor = 17.1234;
            //1 casa decimal
            Console.WriteLine(valor.ToString("F1"));
            //Monetário
            Console.WriteLine(valor.ToString("C"));
            //Percentual
            Console.WriteLine(valor.ToString("P"));

            //Personalizado
            Console.WriteLine(valor.ToString("#.##"));


            CultureInfo cultureInfo = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C0", cultureInfo));

            var inteiro = 256;

            //zeros a direita
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
