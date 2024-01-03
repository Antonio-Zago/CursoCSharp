using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Publico";

        //Transmitido por herança
        protected string CorOlhos = "azul";

        //mesmo projeto assembly
        internal string CorCamisa = "verde";

        //herança ou mesmo projeto
        internal protected string CorBermuda = "branco";

        //trasmitido por herança para classe no mesmo projeto
        private protected string Segredo = "bla bla";

        //só na classe
        private string teste = "";
    }
}
