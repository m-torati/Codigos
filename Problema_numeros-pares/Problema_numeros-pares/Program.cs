using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia N números inteiros 
             * e armazene-os em um vetor. Em seguida, mostre na 
             * tela todos os números pares, e também a quantidade
             * de números pares. */

            Console.Write("Digite no máximo 10 números inteiros: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 10) Console.Write("Digite novamente: ");
            int[] vetor = new int[n];
            for (int i = 0; i < vetor.Length; i++) // preenchendo o array 'vetor'
            {
                Console.Write($"Digite o {i + 1}º número: ");
                while (!int.TryParse(Console.ReadLine(), out vetor[i])) Console.Write("Digite novamente: ");
            }
            int qtdPares = 0;
            int[] pares = new int[n];
            int indicePar = 0;

            // próximo 'for' para verificar os pares do array 'vetor'
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares[indicePar] = vetor[i];
                    qtdPares++;
                    indicePar++;
                }
            }
            if (qtdPares > 0)
            {
                Console.Write("Números pares: ");
                for (int i = 0; i < qtdPares; i++) Console.Write($"{pares[i]} ");
                Console.WriteLine($"\nQuantidade de pares: {qtdPares}");
            }
            else Console.WriteLine("Nenhum número par encontrado");
        }
    }
}
