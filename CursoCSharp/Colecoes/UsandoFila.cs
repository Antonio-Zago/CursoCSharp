using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoFila
    {
        public void Executar()
        {
            //FIFO - first in, first off
            var fila = new Queue<string>();

            fila.Enqueue("Fulanoi");
            fila.Enqueue("Siclano");

            Console.WriteLine(fila.Peek());

            fila.Dequeue();
        }
    }
}
