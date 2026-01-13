using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/Deseja-se converter uma medida de temperatura da escala Celsius para Fahrenheit ou vice-versa./*/
            Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
            Console.Write("A temperatura que deseja converter está em (C)elsius ou (F)ahrenheit?: ");
            char escala = char.ToUpper(Console.ReadLine()[0]);
            if (escala != 'C' && escala != 'F') {
                Console.WriteLine("Escala inválida. Por favor, reinicie o programa e escolha entre 'C' ou 'F'.");
                return;
            }
            else if (escala == 'C') {
                Console.Write("Digite a temperatura em Graus Celsius: ");
                float tempC;
                while (!float.TryParse(Console.ReadLine(), out tempC)) Console.Write("Valor inválido. Digite novamente: ");
                float tempF = (tempC * 9 / 5) + 32;
                Console.WriteLine($"A tempetura em Fahrenheit é {tempF}");
            }
            else {
                Console.Write("Digite a temperatura em Graus Fahrenheit: ");
                float tempF;
                while (!float.TryParse(Console.ReadLine(), out tempF)) Console.Write("Valor inválido. Digite novamente: ");
                float tempC = (tempF - 32) * 5f / 9f;
                Console.WriteLine($"A tempetura em Graus Celsius é {tempC:F2}");
            }
            Console.ReadKey();
        }
    }
}
