using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_abaixo_da_media
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um número inteiro N 
             * e depois um vetor de N números reais. 
             * Em seguida, mostrar na tela a média aritmética 
             * de todos elementos com três casas decimais. 
             * Depois mostrar todos os elementos do vetor 
             * que estejam abaixo da média, com uma casa decimal cada. */

            Console.Write("Quantos números você irá digitar no vetor?: "); // determina indiretamente
                                                                           // o tamanho do vetor
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) { Console.Write("Erro. Digite novamente: "); } // validação
                                                                                                                      // dos dados
            float[] vetor = new float[n]; // criação do vetor
            float soma = 0; // necessario determinar
                            // que soma é igual a zero
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"Digite o {i+1}º número: "); // percorrendo o vetor
                while (!float.TryParse(Console.ReadLine(), out vetor[i])) { Console.Write("Erro. Digite novamente: "); } // validação
                                                                                                                         // dos dados
                soma+= vetor[i];
            }
            Console.WriteLine("--------------------------");
            bool encontrou = false; // usando o método
                                    // de verdadeiro ou falso

            float media = soma / n; // determinando a média
            Console.WriteLine($"A média é {media:F3}");
            Console.WriteLine("ELEMENTOS ABAIXO DA MÉDIA:");
            for (int i = 0; i < vetor.Length; i++) if (vetor[i] < media) { Console.WriteLine(vetor[i].ToString("F2")); encontrou = true; } // vendo quais
                                                                                                                                           // numeros estao
                                                                                                                                           // abaixo da media
            if (!encontrou) Console.WriteLine("Nenhum");
        }
    }
}
