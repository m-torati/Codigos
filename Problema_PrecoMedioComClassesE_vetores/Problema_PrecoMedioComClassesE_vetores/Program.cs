using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problema_PrecoMedioComClassesE_vetores
{
    class Produto
    {
        private string _nome; 
        private double _preco; 
        public string Nome 
        { 
            get => _nome; 
            set 
            { 
                if (string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentException("O nome não pode ser vazio."); 
                _nome = value; 
            } 
        }
        public double Preco 
        { 
            get => _preco; 
            set 
            { 
                if (value <= 0) 
                    throw new ArgumentException("O preço deve ser maior que zero."); 
                _preco = value; 
            } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos irá inscrever?: "); int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) { Console.Write("Erro. Digite novamente: "); }

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nProduto #{i + 1}");

                // Nome
                string name;
                do
                {
                    Console.Write("Digite o nome do produto: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name)) Console.WriteLine("Erro: o nome não pode estar vazio.");

                } while (string.IsNullOrWhiteSpace(name));

                // Preco
                Console.Write("Digite seu preço: R$"); double preco;
                while (!double.TryParse(Console.ReadLine(), out preco) || preco <= 0) { Console.Write("Erro. Digite novamente: R$"); }


                // criação do objeto
                vetor[i] = new Produto { Nome = name, Preco = preco };
            }
            Console.Clear();
            Console.WriteLine("Produtos cadastrados");

            foreach (Produto p in vetor) Console.WriteLine($"- {p.Nome}: R${p.Preco:F2}");

            double soma = 0;
            for (int i = 0; i < n; i++) soma += (float)vetor[i].Preco;
            double avg = soma / n;
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($"\nPREÇO MÉDIO: R${avg:F2}");
            Console.ReadKey();
        }
    }
}
