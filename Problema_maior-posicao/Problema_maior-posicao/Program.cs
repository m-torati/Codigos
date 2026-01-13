using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_maior_posicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia N números reais e armazene-os em um vetor. 
             * Em seguida, mostrar na tela 
            o maior número do vetor (supor não haver empates).
            Mostrar também a posição do maior elemento, 
            considerando a primeira posição como 0 (zero). */
            
            Console.Write("Quantos números inteiros você irá digitar?: ");
            int numeros;
            while (!int.TryParse(Console.ReadLine(), out numeros)) { Console.Write("Erro. Digite novamente: "); } // validacao dos dados
            int[] vetor = new int[numeros];
            for (int i = 0; i<vetor.Length; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                while (!int.TryParse(Console.ReadLine(), out vetor[i])) { Console.Write("DIGITE NOVAMENTE: "); } // validacao dos dados
            }
            int maior = vetor[0]; // declarando que o primeiro
                                  // numero do vetor é o maior
            int posicao = 0;
            for (int j = 1; j < vetor.Length; j++) // percorrendo os numeros do vetor
                                                   // para ver qual realmente é o maior
            {
                if (vetor[j] > maior)
                {
                    maior = vetor[j];
                    posicao = j; // atualiza a posicao do maior
                }
            }
            Console.WriteLine($"O maior número é {maior}");
            Console.WriteLine($"Ele está na posicao {posicao+1}");
        }
    }
}
