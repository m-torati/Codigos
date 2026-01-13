using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_diagonal_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um número inteiro N (máximo = 10)
             * e uma matriz quadrada de ordem N contendo números inteiros. 
             * Em seguida, mostrar a diagonal principal e a quantidade de 
             * valores negativos da matriz.*/

            Console.Write("Qual a ordem da matriz?: "); int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n<= 0) {  Console.Write("Erro. Digite um número válido: "); }
            int[,] matriz = new int[n,n];
            Console.Write("Números inteiros e o máximo é 10");
            Console.Clear();
            for (int i = 0; i<n;i++)
            {
                for (int j = 0; j<n;j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matriz[i,j])) { Console.Write("Erro. Digite novamente: "); }
                }
            }
            Console.Write("\nDiagonal principal: ");
            for (int i = 0; i < n; i++) { Console.Write(matriz[i, i] + " "); }
            int negativos = 0;
            for (int i = 0; i < n; i++) { for (int j = 0; j<n;j++) { if (matriz[i, j] < 0) negativos++; } }
            Console.WriteLine("\nNúmeros negativos: "+negativos);
            Console.WriteLine("Matriz formatada:");
            for (int i = 0; i < n; i++) // percorre as linhas
            {
                for (int j = 0; j < n; j++) // percorre as colunas
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(4));
                    // PadLeft(4) reserva 4 espaços para cada número
                }
                Console.WriteLine(); // quebra de linha ao final da linha
            }
        }
    }
}
