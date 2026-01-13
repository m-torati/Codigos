using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma
            casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida,
            o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com
            duas casas decimais, conforme exemplo. */

            Console.Write("Digite o comprimento do terreno (em metros): ");
            float comprimento;
            while (!float.TryParse(Console.ReadLine(), out comprimento) || comprimento <= 0) {
                Console.Write("Entrada inválida. Por favor, digite um número positivo para o comprimento: ");
            }
            Console.Write("Digite a largura do terreno (em metros): ");
            float largura;
            while (!float.TryParse(Console.ReadLine(), out largura) || largura <= 0) {
                Console.Write("Entrada inválida. Por favor, digite um número positivo para a largura: ");
            }
            Console.Write("Digite o valor do metro quadrado do terreno: R$");
            float metroquadrado;
            while (!float.TryParse(Console.ReadLine(), out metroquadrado) || metroquadrado <= 0) {
                Console.Write("Entrada inválida. Por favor, digite um número positivo para o valor do metro quadrado: R$");
            }
            float area = comprimento * largura;
            float preco = area * metroquadrado;
            Console.WriteLine($"AREA DO TERRENO = {area:F2} m²");
            Console.WriteLine($"PREÇO DO TERRENO = R${preco:F2}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
