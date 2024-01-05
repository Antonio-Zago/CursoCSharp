using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class ExcessoesPersonalizadas
    {
        public int Positivo()
        {
            Random random = new Random();
            var valor = random.Next(-5, -1);

            if (valor< 0)
            {
                throw new NegativoException("Número negativo");
            }

            return valor;
        }
        public void Executar()
        {
            try
            {
                var valor = Positivo();
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class NegativoException : Exception
    {
        public NegativoException() { }

        public NegativoException(string msg) : base(msg) { }

        public NegativoException(string msg, Exception inner) : base(msg, inner) { }
    }


}
