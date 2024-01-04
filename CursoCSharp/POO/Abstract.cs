using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Abstract
    {
        public void Executar()
        {
            //Não funciona porque é uma classe abstrata
            //Celular celular = new Celular();
        }
    }

    //Classe que alguma outra classe deve herdar dela
    //Classe inacabada
    
    public abstract class Celular
    {
        //Método abstrado (sem corpo)
        public abstract void Assistente();

        public string Tocar()
        {
            return "plim";
        }
    }

    public class Samsung : Celular
    {
        //Todos os métodos abstratos devem ser implementados pela classe concreta
        public override void Assistente()
        {
            throw new NotImplementedException();
        }
    }
}
