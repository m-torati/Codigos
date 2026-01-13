using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problema_soma_linhas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler dois números inteiros M e N (máximo = 10). 
             * Em seguida, ler uma matriz de M linhas e N colunas contendo números reais. 
             * Gerar um vetor de modo que cada elemento do vetor seja a soma dos elementos
             * da linha correspondente da matriz. Mostrar o vetor gerado. */

            Console.Write("Qual a quantidade de linhas da matriz?: "); int M; // linhas
            while (!int.TryParse(Console.ReadLine(), out M) || M>10 || M<1) { Console.Write("Erro. Digite novamente (1 a 10): "); } // entrada e
                                                                                                                                    // validação
                                                                                                                                    // dos dados
            
            Console.Write("Qual a quantidade de colunas da matriz?: "); int N; // colunas
            while (!int.TryParse(Console.ReadLine(), out N) || N>10 || N<1) { Console.Write("Erro. Digite novamente (1 a 10): "); } // entrada e
                                                                                                                                    // validação
                                                                                                                                    // dos dados
            double[,] matriz = new double[M, N]; // criação da matriz
            double[] vetor = new double[M]; // criação do vetor

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"\nDigite os elementos da {i + 1}ª linha:");
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    double valor;
                    string entrada = Console.ReadLine();

                    // Aceita vírgula ou ponto como separador decimal
                    while (!double.TryParse(entrada, NumberStyles.Float, CultureInfo.CurrentCulture, out valor) &&
                           !double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
                    // NumberStyle.Float --> permite números com casas decimais, sinais (+/-), etc.
                    // CultureInfo.CurrentCulture --> usa a cultura do sistema (no Brasil, geralmente vírgula como separador decimal)
                    // Culture.InvariantCulture --> usa uma cultura padrão (geralmente ponto como separador decimal).
                    // Resultado: é válido inserir tanto 3,5 quanto 3.5
                    {
                        Console.Write("Erro. Digite um número real válido: ");
                        entrada = Console.ReadLine();
                    }

                    matriz[i, j] = valor;
                }
            }

            // Soma por linha
            for (int i = 0; i < M; i++)
            {
                vetor[i] = 0.0; // zera a soma da linha i
                for (int j = 0; j < N; j++)
                    vetor[i] += matriz[i, j];
            }

            Console.Clear();
            Console.WriteLine("VETOR GERADO:");
            for (int i = 0; i < M; i++)
                Console.WriteLine(vetor[i].ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
