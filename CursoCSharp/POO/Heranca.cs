using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    public class Heranca
    {
        public void Executar()
        {
            Console.WriteLine("Uno...");
            Uno c1 = new Uno();
            //Método Acelerar e freiaer
            Console.WriteLine( c1.Acelerar());
            Console.WriteLine(c1.Acelerar());
            Console.WriteLine(c1.Freiar());
            Console.WriteLine(c1.Freiar());


            Console.WriteLine("Ferrari...");
            Ferrari c2 = new Ferrari();
            //Método Acelerar e freiaer
            Console.WriteLine(c2.Acelerar());
            Console.WriteLine(c2.Acelerar());
            Console.WriteLine(c2.Freiar());
            Console.WriteLine(c2.Freiar());

            Console.WriteLine("Ferrari com tipo carro...");

            //Nesse caso como o método acelerar é sobscrito e o método freiar é ocultado, ao realizar o polimorfismo
            //o método sobscrito pega da classe que foi instanciada, Ferrari
            //e o método que foi ocultado na classe pai pega da classe pai, ou seja, do tipo da variavel (Carro) 
            Carro c3 = new Ferrari();//Polimorfismo
            Console.WriteLine(c3.Acelerar());
            Console.WriteLine(c3.Acelerar());
            Console.WriteLine(c3.Freiar());
            Console.WriteLine(c3.Freiar());

            //Não funciona porque é um método protected e deve ser chamado somente dentro da classe qiue herda de carro
            //c1.AlterarVelocidade();
            

        }
    }

    public class Carro
    {
        //protect é transmitida por herança, pode ser modificada dentro da classe que herda de carro
        protected readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        //Transmitido por herança, pode ser modificada dentro da classe que herda de carro
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if(novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        //Com o atributo virtual eu consigo sobscrever esse método
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Freiar()
        {
            return AlterarVelocidade(-5);
        }
    }

    class Uno : Carro
    {
        //Necessário declarar dessa forma para que o construtor de Uno chame o construtor de carro que foi criado, porque Uno herda de Carro e carro não possui contrutor base:
        /*
         public Carro(){}
         */
        public Uno() : base(200){}


        //Exemplo de acesso a um método protected dentro da classe que herda de carro
        private void teste()
        {
            AlterarVelocidade(1000);
        }
    }

    class Ferrari : Carro
    {
        public Ferrari() : base(300) { }

        //sobscrevendo método do pai
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //Oculta método da classe pai,
        public new int Freiar()
        {
            return AlterarVelocidade(-15);
        } 
    }
}
