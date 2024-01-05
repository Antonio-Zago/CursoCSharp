using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class UsandoNullable
    {
        public void Executar()
        {
            //Passa a aceitar nulo
            int? num = null;

            if (num.HasValue)
            {
                int num2 = num.Value;
                Console.WriteLine("Tem valor");
            }
            //Se utilizado o .Value em um valor nulo da erro
            //int num2 = num.Value;

            int num3 = num.HasValue ? num.Value : 0;


        }
    }
}
