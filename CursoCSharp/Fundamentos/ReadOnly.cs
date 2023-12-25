using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class ReadOnly
    {
        public void Executar()
        {
            Cliente cliente = new Cliente("Antonio", DateTime.Now);

            //Esse tipo de operação não é possivel fazer para atributo readonly
            //cliente.Nome = "Teste";
        }
    }

    public class Cliente
    {
        //Atributo readonly é parecido com constante, porém só é possivel setar o valor no construtor da classe
        public readonly string Nome;
        public DateTime Data;


        public Cliente(string nome, DateTime data)
        {
            Nome = nome;
            Data = data;
        }

        public Cliente(){}

    }
}
