using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor 
            da área, perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplos. */

            Console.Write("Digite a largura do retângulo: ");
            float largura;
            while(!float.TryParse(Console.ReadLine(), out largura) || largura <= 0) {
                Console.Write("Entrada inválida. Por favor, digite um número positivo para a largura: ");
            }
            Console.Write("Digite a altura do retângulo: ");
            float altura;
            while (!float.TryParse(Console.ReadLine(), out altura) || altura <= 0) {
                Console.Write("Entrada inválida. Por favor, digite um número positivo para a altura: ");
            }
            float area = largura * altura;
            float perimetro = (2*largura)+(2*altura);
            double diagonal = Math.Sqrt((largura * largura) + (altura * altura));
            Console.WriteLine("Área = " + area.ToString("F4"));
            Console.WriteLine("Perímetro = " + perimetro.ToString("F4"));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4"));
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
