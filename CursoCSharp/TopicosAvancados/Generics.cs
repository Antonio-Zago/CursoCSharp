using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Generics
    {
        public void Executar()
        {
            Caixa<string> caixa = new Caixa<string>("bla", "blabla");

            Console.WriteLine(caixa.Coisa);

        }
    }

    class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa( T coisa, T valorPrivadoParam)
        {
            valorPrivado = valorPrivadoParam;
            Coisa = coisa;
        }
    }

    //Defini que CaixaInt herda da minha classe generica passando o int para o T
    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0,0) { }
    }
}
