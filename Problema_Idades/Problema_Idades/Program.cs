using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler o nome e idade de duas pessoas. 
             * Ao final mostrar uma mensagem com os 
             * nomes e a idade média entre essas pessoas,   
             * com uma casa decimal, conforme exemplo. */

            Console.Write("Insira o nome da primeira pessoa: ");
            string nome1 = Console.ReadLine();
            Console.Write("Insira a idade da primeira pessoa: ");
            int idade1;
            while(!int.TryParse(Console.ReadLine(), out idade1) || idade1>=0) {
                Console.Write("Entrada inválida. Por favor, insira um número inteiro para a idade: ");
            }
            Console.Write("Insira o nome da segunda pessoa: ");
            string nome2 = Console.ReadLine();
            Console.Write("Insira a idade da segunda pessoa: ");
            int idade2;
            while (!int.TryParse(Console.ReadLine(), out idade2) || idade2 >= 0) {
                Console.Write("Entrada inválida. Por favor, insira um número inteiro para a idade: ");
            }
            double media = (idade1 + idade2) / 2f;
            Console.WriteLine($"A idade média de {nome1} e {nome2} é de {media:F1} anos.");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
