using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_soma_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois vetores A e B, contendo N elementos cada. 
             * Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos 
             * elementos correspondentes de A e B. Imprima o vetor C gerado. */

            Console.Write("Quantos valores terá cada vetor?: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n<=0) { Console.Write("Erro. Digite novamente: "); }
            int[] vetorA = new int[n];
            int[] vetorB = new int[n];
            int[] vetorSOMA = new int[n];
            Console.WriteLine("------------------------------");
            for (int i = 0; i < vetorA.Length; i++) {
                Console.Write($"Digite o {i + 1}º valor do vetor A: ");
                while (!int.TryParse(Console.ReadLine(), out vetorA[i])) { Console.Write("Erro. Digite novamente: "); }
            }
            Console.WriteLine("------------------------------");
            for (int i = 0; i < vetorB.Length; i++) {
                Console.Write($"Digite o {i + 1}º valor do vetor B: ");
                while (!int.TryParse(Console.ReadLine(), out vetorB[i])) { Console.Write("Erro. Digite novamente: "); }
            }
            for (int i = 0; i<vetorSOMA.Length;i++) vetorSOMA[i] = vetorA[i] + vetorB[i];
            Console.WriteLine("------------------------------");
            Console.WriteLine("VETOR RESULTANTE");
            Console.WriteLine(string.Join(", ",vetorSOMA));
        }
    }
}
