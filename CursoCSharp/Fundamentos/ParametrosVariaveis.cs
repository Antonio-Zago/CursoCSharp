using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ParametrosVariaveis
    {

        public void Executar() {
            Recepcionar("pedro","manu","cris");
        }

        public void Recepcionar(params string[] pessoas) {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}");
            }
        }
    }
}
