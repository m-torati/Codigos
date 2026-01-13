using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_cada_linha
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler um inteiro N e uma matriz quadrada de ordem N (máximo = 10).
             * Mostrar qual o maior elemento de cada linha. Suponha não haver empates.*/


            Console.WriteLine("=== IDENTIFICADOR DO MAIOR DE CADA LINHA ===");

            Console.Write("Qual será a ordem da matriz?: "); int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n>10) { Console.Write("Erro. Digite novamente: "); } // entrada e
                                                                                                                              // validação
                                                                                                                              // dos dados
            Console.Clear();
            int[,] matriz = new int[n, n]; // criação da matriz
            for (int i = 0; i<n;i++) // percorrendo as linhas
            {
                for (int j=0;j<n;j++) // percorrendo as colunas
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matriz[i,j])) { Console.Write("Erro. Digite novamente: "); } // entrada e
                                                                                                                              // validação
                                                                                                                              // dos dados
                }
            }
           
            Console.WriteLine("\nMAIOR NÚMERO DE CADA LINHA");
            // Processamento: maior de cada linha
            for (int i = 0; i < n; i++)
            {
                int maior = matriz[i, 0]; // começa com o primeiro elemento da linha
                for (int j = 1; j < n; j++) // percorre o resto da linha
                {
                    if (matriz[i, j] > maior) maior = matriz[i, j];
                }
                Console.WriteLine($"Linha {i+1}: {maior}");
            }
        }
    }
}
