using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_soma_vetor
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Faça um programa que leia N números reais e armazene-os em um vetor. 
             * Em seguida: - Imprimir todos os elementos do vetor
             * Mostrar na tela a soma e a média dos elementos do vetor  */


            Console.Write("Digite entre 1 e 10 números inteiros:  ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10) Console.Write("Inválido. Digite novamente: ");
            int[] vetor = new int[n];
            int media;
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++) { Console.Write($"Digite o {i + 1}º número: "); vetor[i] = int.Parse(Console.ReadLine());  soma = vetor[i] + soma; }            
            media = soma / n;
            Console.Write("VALORES: ");
            for (int i = 0; i < vetor.Length; i++) { Console.Write($"{vetor[i]:0.0}   "); }
            Console.WriteLine($"\nSOMA: {soma}");
            Console.WriteLine($"MÉDIA: {media}");
        }
    }
}
