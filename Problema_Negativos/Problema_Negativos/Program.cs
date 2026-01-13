using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número inteiro positivo N (máximo = 10) 
             * e depois N números inteiros e armazene-os em um vetor. 
             * Em seguida, mostrar na tela todos os números negativos lidos.*/

            Console.Write("Digite no máximo dez números inteiros: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10) Console.Write("Entrada inválida. Digite um número inteiro entre 1 e 10: ");
            int[] vetor = new int[n];
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"Digite o {i + 1}º número: ");
                while (!int.TryParse(Console.ReadLine(), out vetor[i])) Console.Write("Entrada inválida. Digite um número inteiro: ");
            }
            int negativo = 0;
            for (int i = 0; i < vetor.Length; i++) {
                if (vetor[i] < 0)
                {
                    negativo = vetor[i];
                    Console.WriteLine($"Número(s) negativo(s) encontrado(s): {negativo}");
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
