using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    //Criei um tipo Operacao
    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public void Executar()
        {
            //Ao criar uma variavel do tipo Operacao que é um delegate esperasse que seja atribuido uma função que respeite a assinatura do método
            Operacao sum = (x,y) => x + y;

            
        }
    }
}
