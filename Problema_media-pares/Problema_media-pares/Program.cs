using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_media_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um vetor de N números inteiros. 
             * Em seguida, mostrar na tela a média aritmética somente 
             * dos números pares lidos, com uma casa decimal. 
             * Se nenhum número par for digitado, mostrar a mensagem 
             * "NENHUM NUMERO PAR" */

            float soma=0, qtdPares=0;
            Console.WriteLine("Digite apenas números INTEIROS"); 
            Console.Write("Quantos elementos terá o vetor?: "); int n; // determinando indiretamente
                                                                       // o tamanho do vetor
            while (!int.TryParse(Console.ReadLine(), out n)) // validação dos dados
            { 
                Console.Write("Erro. Digite novamente: ");
            }
            int[] vetor = new int[n]; // criação do vetor
            for (int i = 0; i<vetor.Length;i++) // percorrendo o vetor
            {
                Console.Write($"Digite o {0+1}º número do vetor: ");
                while (!int.TryParse(Console.ReadLine(), out vetor[i])) // validação dos dados
                { 
                    Console.Write("Erro. Digite novamente: ");
                }
                if (vetor[i] % 2 == 0) // verificando individualmente
                                       // cada elemento do vetor,
                                       // se é par ou ímpar
                {
                    soma += vetor[i]; // somando os nº pares
                                      // para fazer a media
                                      
                    qtdPares++; // toda vez que encontrar um nº par,
                                // vai registrando através de uma soma
                }
            }
            if (qtdPares == 0) Console.WriteLine("NENHUM NÚMERO PAR"); // se não encontrando nenhum par
            else // se encontrar números pares
            {
                float media = soma / qtdPares;
                Console.WriteLine($"\nMÉDIA DOS PARES = {media:F1}");
            }
        }
    }
}
