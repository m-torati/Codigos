using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos analisar se a palavra é um palíndromo.");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            string invertida = InverterPalavra(palavra);

            if (palavra.ToLower() == invertida.ToLower()) { Console.WriteLine($"'{palavra}' É um palíndromo!"); }
            else { Console.WriteLine("Não é um palíndromo."); }
        }
        static string InverterPalavra(string palavra)
        {
            string resultado = "";
            for (int i = palavra.Length - 1; i >= 0; i--) {
                resultado += palavra[i];
            }
            return resultado;
        }
    }
}
