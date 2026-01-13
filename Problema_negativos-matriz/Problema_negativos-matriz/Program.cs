using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_negativos_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler dois números M e N (máximo = 10), e depois ler uma matriz MxN 
             * de números inteiros, conforme exemplo. Em seguida, mostrar na tela
             * somente os números negativos da matriz. */

            Console.WriteLine("=== IDENTIFICADOR DE NÚMEROS NEGATIVOS ===");
            Console.Write("\nQual a quantidade de linhas da matriz?: "); int linhas;
            while (!int.TryParse(Console.ReadLine(), out linhas) || linhas <0) { Console.Write("Erro. Digite novamente: ");  } // entrada e
                                                                                                                               // validação
                                                                                                                               // dos dados
            Console.Write("Qual a quantidade de colunas da matriz?: "); int colunas;
            while (!int.TryParse(Console.ReadLine(), out colunas) || colunas < 0) { Console.Write("Erro. Digite novamente: "); } // entrada e
                                                                                                                                 // validação
                                                                                                                                 // dos dados
            
            int[,] matriz = new int[linhas,colunas]; // criação da matriz
            for (int i =0;i<linhas;i++) // percorre as linhas
            {
                for (int j = 0; j < colunas; j++) // percorre as colunas
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matriz[i, j])) { Console.Write("Erro. Digite novamente: "); } // entrada
                                                                                                                               // e validação
                                                                                                                               // dos dados
                }
            }
                
            Console.WriteLine("\nVALORES NEGATIVOS");

            for (int i = 0; i < linhas; i++) // percorrendo as linhas
            {
                for (int j = 0; j < colunas; j++) // percorrendo as colunas
                {
                    if (matriz[i, j] < 0) Console.WriteLine(matriz[i, j]); // imprimir se o elemento for negativo
                }
            }
            Console.ReadKey();
        }
    }
}
