using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class IgualdadeEHashCode
    {
        public void Executar()
        {
            var p1 = new Produto("teste", 1.8);
            var p2 = new Produto("teste", 1.8);

            Console.WriteLine(p1 == p2);

            Console.WriteLine(p1.Equals(p2) );

            //O HashSet utiliza o Equals para verificar se é o mesmo item, mesmo implementando o equals para o objeto
            //produto, continuou adicionando na lista porque utiliza o método getHashCode para fazer a igualdade do objeto
            var set = new HashSet<Produto>();
            set.Add(p1) ;
            set.Add(p2);

            foreach (var produto in set) 
            { 
                Console.WriteLine(produto.Nome);
            } 
        }
    }

    class Produto
    {
        public string Nome;

        public double Valor;
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        //Implementei o Equals da classe e comparei cada atributo do objeto para dizer se é o mesmo objeto
        public override bool Equals(object? obj)
        {
            Produto outroProduto = (Produto)obj;
            var mesmoNome = Nome == outroProduto.Nome;
            var mesmoPreco = Valor == outroProduto.Valor;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            //O hash code gerado é o tamanho do nome
            return Nome.Length;
        }
    }
}
