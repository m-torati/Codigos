using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_soma_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler duas matrizes de números inteiros A e B, 
             * contendo de M linhas e N colunas cada (M e N máximo = 10). Depois,
             * gerar uma terceira matriz C onde cada elemento desta é a soma 
             * dos elementos correspondentes das matrizes originais. Imprimir na tela
             * a matriz gerada. */

            Console.Write("Quantas linhas (M) terá cada matriz?: "); int M;
            while (!int.TryParse(Console.ReadLine(), out M) || M <= 0 || M > 10)
            {
                Console.Write("Erro. Digite um número entre 1 e 10: "); // entrada e validação
            }
            Console.Write("Quantas colunas (N) terá cada matriz?: "); int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0 || N > 10)
            {
                Console.Write("Erro. Digite um número entre 1 e 10: "); // entrada e validação
            }

            int[,] matrizA = new int[M, N];
            int[,] matrizB = new int[M, N];
            int[,] matrizC = new int[M, N];
            Console.Clear();
            Console.WriteLine($"Insira os elementos da Matriz A: ");
            for (int i = 0;i<M;i++) // MATRIZ A
            {
                for (int j=0;j<N;j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrizA[i,j])) { Console.Write("Erro. Digite novamente: "); }
                }
            }
            Console.WriteLine($"\nInsira os elementos da Matriz B: ");
            for (int i = 0; i < M; i++) // MATRIZ B
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrizB[i, j])) { Console.Write("Erro. Digite novamente: "); }
                }
            }
            Console.Clear();
            for (int i = 0; i < M; i++) // MATRIZ C
            {
                for (int j = 0; j < N; j++) { matrizC[i, j] = matrizA[i, j] + matrizB[i, j]; }
            }
            Console.WriteLine("MATRIZ RESULTANTE DA SOMA: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrizC[i, j].ToString().PadRight(5));
                    // cada número ocupa 5 espaços, alinhado à direita
                }
                Console.WriteLine();
            }
        }
    }
}
