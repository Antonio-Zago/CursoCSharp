using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class usandoThis
    {

        public void Executar()
        {
            Sandero sandero = new Sandero(100, "teste");
            Console.WriteLine(sandero.Velocidade);
        }
        

        
    }

    class Carro2
    {

    }

    class Sandero : Carro2
    {
        public int Velocidade;
        public Sandero(int velocidade) 
        {
            Velocidade = velocidade;
        }  

        //Construtor que chama outro construtor da mesma classe usando o this
        public Sandero(int velocidaMaxima, string nome) : this(velocidaMaxima){ }
    }
}
