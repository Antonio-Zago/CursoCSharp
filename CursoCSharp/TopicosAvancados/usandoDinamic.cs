using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class usandoDinamic
    {
        public void Executar()
        {
            //Torna a variavel fracamente tipada
            dynamic meuObjeto = "teste";

            meuObjeto = 1;
        }
    }
}
