using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler nome, idade e altura de N pessoas, conforme exemplo. 
             * Depois, mostrar na tela a altura média das pessoas, 
             * e mostrar também a porcentagem de pessoas com menos de 16 anos, 
             * bem como os nomes dessas pessoas caso houver. */

            Console.Write("Quantas pessoas serão digitadas?: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0) Console.Write("INVÁLIDO. Digite novamente: ");
            float[] altura = new float[n];
            string[] nome = new string[n];
            int[] idade = new int[n];
            float soma = 0;
            float media;
            for (int i = 0; i < nome.Length; i++) 
            {
                Console.WriteLine($"Dados da {i + 1}ª pessoa");
                Console.Write("Nome: "); // RODAR O NOME PRIMEIRO
                nome[i] = Console.ReadLine();
                Console.Write("Idade: "); // RODAR A IDADE DEPOIS
                while (!int.TryParse(Console.ReadLine(), out idade[i]) || idade[i] < 0) Console.Write("Digite novamente: ");
                Console.Write("Altura: "); // RODAR A ALTURA DEPOIS
                while (!float.TryParse(Console.ReadLine(), out altura[i]) || altura[i] < 0) Console.Write("Digite novamente: ");
                soma = soma + altura[i];
            }
            media = soma / n;
            double arredondado = Math.Round(media, 2); // ARREDONDAR E IMPRIMIR
                                                       // COM DUAS CASAS DECIMAIS 
            Console.WriteLine($"Altura Média: {media}");
        }
    }
}
