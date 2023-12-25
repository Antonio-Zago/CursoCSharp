using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{

    interface Ponto
    {
        void MoverDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class Struct
    {


        public void Executar()
        {
            //Não precisei dar new
            Coordenada coordenada;
            coordenada.X = 2;
            coordenada.Y = 2;
        }
    }
}
