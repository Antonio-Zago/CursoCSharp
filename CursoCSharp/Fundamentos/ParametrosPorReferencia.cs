using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ParametrosPorReferencia
    {
        public void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            int b = 2;
            AlterarOut(out b);
            Console.WriteLine(b);

            int c;
            int d;

            AlterarOutDoisRetornos(out c, out d);

            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        public void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public void AlterarOut(out int numero)
        {
            numero = 0;
            numero = numero + 1;
        }

        public void AlterarOutDoisRetornos(out int num1, out int num2)
        {
            num1 = 1000;
            num2 = 2000;
        }

        //ref: recebo uma referencia de um número já inicializado e dentro do método pode ser alterado seu valor
        //out: recebo uma váviavel não inicializada, que após a conclusão do método vai atribuir o valor a variavel
        //out: não pode ser utilizado o valor que é passado pelo parametro, deve ser inicialiazado essa variavel antes
        //Melhor utilizar o out, atribuir valores por referencia pode dar mais problema
    }
}
