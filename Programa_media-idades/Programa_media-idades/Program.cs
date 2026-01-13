using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_media_idades
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler um número indeterminado de dados, 
             * contendo cada um, a idade de um indivíduo. O último dado, 
             * que não entrará nos cálculos, contém um valor de idade negativa. 
             * Calcular e imprimir a idade média deste grupo de indivíduos.
             * Se for entrado um valor negativo na primeira vez, mostrar 
             * a mensagem "IMPOSSIVEL CALCULAR". */

            Console.WriteLine("===MEDIA DA IDADES===");
            int idade;
            float soma = 0;
            int quantidade = 0;
            while (true)
            {
                Console.Write("Digite uma idade: ");
                while (!int.TryParse(Console.ReadLine(), out idade)) { Console.Write("Erro, digite novamente: "); }

                if (idade < 0) {
                    // Se for a primeira entrada negativa
                    if (quantidade == 0) Console.WriteLine("IMPOSSIVEL CALCULAR"); break;
                }
                soma += idade;
                quantidade++;
            }
            if (quantidade > 0)
            {
                float media = soma / quantidade;
                Console.WriteLine($"A média de idades é {media:F2} anos");
            }
        }
    }
}
