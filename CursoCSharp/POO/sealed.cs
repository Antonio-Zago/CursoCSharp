using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class @sealed
    {
        public void Executar()
        {

        }
    }

    //Classe que não permite herança
    sealed class SemFilho
    {
        public double Valor()
        {
            return 10.1;
        }
    }
}
