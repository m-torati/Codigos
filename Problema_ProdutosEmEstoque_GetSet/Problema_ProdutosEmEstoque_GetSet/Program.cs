using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Problema_ProdutosEmEstoque_GetSet
{
    class Produto
    {
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotalEmEstoque() { return Preco * Quantidade; }
        public void AdicionarProdutos(int quantidade) => Quantidade += quantidade;
        public void RemoverProdutos(int quantidade)
        {
            if (quantidade > Quantidade) Console.Write("Erro: não há estoque suficiente para remover");
            else Quantidade -= quantidade;
        }
        public Produto(string nome, double preco, int quantidade) // construtor 
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; } // propriedade para retornar o nome do produto instanciado
                                  // lá no Main lembrando que, o atributo Nome tornou-se _nome,
                                  // porque antes era 'public' agora é 'private'

            set { if (value != null && value.Length > 1) _nome = value; } // propriedade que permite
                                                                          // o usuário mudar o nome
                                                                          // do Produto
        }
        
        public override string ToString() // método que imprime o resultado final
        {
            return _nome
                + ", R$"
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidade(s), Total: R$"
                + ValorTotalEmEstoque().ToString("F2");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço de cada unidade do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // criar o produto com os dados informados
            Produto p = new Produto(nome, preco, quantidade);
            p.Quantidade = quantidade; // usa o 'set' da propriedade

            Console.WriteLine("\nDados do produto: ");
            Console.WriteLine(p); // chama o ToString()

            Console.Write("\nDigite a quantidade que deseja remover do produto: ");
            int remover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remover); // estamos chamando o método para remover os produtos

            Console.WriteLine(p.ToString());
        }
    }
}
