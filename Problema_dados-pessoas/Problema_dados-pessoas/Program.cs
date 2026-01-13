using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Problema_dados_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tem-se um conjunto de dados contendo a altura e o gênero (M, F) de N pessoas.
             * Fazer um programa que calcule e escreva a maior e a menor altura do grupo, a 
             * média de altura das mulheres, e o número de homens. */

            Console.Write("Qual será a quantidade de elementos no vetor?: "); int n; // determinando indiretamente
                                                                                     // o tamanho do vetor
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) { Console.Write("Erro. Digite novamente: "); } // entrada e
                                                                                                                      // validação
                                                                                                                      // dos dados
            float[] altura = new float[n];
            string[] sexo = new string[n];
            float somaMulheres = 0;
            int qtdMulheres = 0;
            int qtdHomens = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDados da {i + 1}ª pessoa");

                Console.Write("Altura: ");
                while (!float.TryParse(Console.ReadLine(), out altura[i]) || altura[i] <= 0) { Console.Write("Digite novamente: "); } // entrada e
                                                                                                                                      // validação
                                                                                                                                      // dos dados
                
                Console.Write("Sexo (F/M): ");
                sexo[i] = Console.ReadLine().ToUpper(); // entrada dos dados tipo string
                
                while (sexo[i] != "F" && sexo[i] != "M") // validação dos dados tipo string
                { 
                    Console.Write("Digite novamente (F/M): "); 
                    sexo[i] = Console.ReadLine().ToUpper();
                }

                if (sexo[i] == "F")
                {
                    somaMulheres += altura[i]; // soma das alturas das mulheres para a média
                    qtdMulheres++;
                }
                else qtdHomens++;
            }
            float menorAltura = altura.Min(); // determinando a menor altura do vetor
            float maiorAltura = altura.Max(); // determinando a maior altura do vetor

            Console.WriteLine($"\nMenor altura: {menorAltura:F2}");
            Console.WriteLine($"Maior altura: {maiorAltura:F2}");

            if (qtdMulheres > 0)
            {
                float mediaMulheres = somaMulheres / qtdMulheres;
                Console.WriteLine($"Média de altura das mulheres: {mediaMulheres:F2}");
            }
            else Console.WriteLine("Nenhuma mulher foi cadastrada.");

            Console.WriteLine($"Número de homens: {qtdHomens}");
        }
    }
}
