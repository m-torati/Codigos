using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_mais_velho
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um conjunto de nomes
             * de pessoas e suas respectivas idades. Os nomes devem 
             * ser armazenados em um vetor, e as idades em um 
             * outro vetor. Depois, mostrar na tela o nome da pessoa mais velha. */

            Console.Write("Quantos pessoas você vai digitar?: "); int n; // determinando indiretamente
                                                                         // o tamanho do vetor
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) { Console.Write("Erro. Digite novamente: "); } // validação
                                                                                                                      // dos dados
            int[] idade = new int[n];
            string[] nomes = new string[n];
            int posicao=0;
            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa");
                Console.Write("Nome: "); // entrada dos dados tipo string
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                while (!int.TryParse(Console.ReadLine(), out idade[i])) { Console.Write("Erro. Digite novamente: "); } // entrada e
                                                                                                                       // validação
                                                                                                                       // dos dados
                                                                                                                       // tipo int
            }
            int maior = idade[0];
            for (int i = 1; i < idade.Length; i++)
            {
                if (idade[i] > maior)
                {
                    maior = idade[i]; // determinando a maior idade
                    posicao = i; // determinando a posicao da maior idade
                }
            }
            Console.WriteLine($"\nPESSOA MAIS VELHA: {nomes[posicao]}");
        }
    }
}
