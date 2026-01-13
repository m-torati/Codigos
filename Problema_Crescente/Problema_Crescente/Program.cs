using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. 
             * Escreva para cada X e Y uma mensagem que indique se estes valores 
             * foram digitados em ordem crescente ou decrescente. O programa deve 
             * finalizar quando forem digitados dois valores iguais. */

            Console.WriteLine("Digite dois números inteiros abaixo.");
            int numero1, numero2;
            while (true)
            {
                Console.Write("\nDigite o 1º número: ");
                while (!int.TryParse(Console.ReadLine(), out numero1)) { Console.Write("Digite novamente: "); }
                Console.Write("Digite o 2º número: ");
                while (!int.TryParse(Console.ReadLine(), out numero2)) { Console.Write("Digite novamente: "); }
                if (numero1 > numero2) Console.WriteLine("Decrescente!!");
                else if (numero1 < numero2) Console.WriteLine("Crescente!!");
                else { break; }
            }
            Console.WriteLine("Programa encerrado.");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
