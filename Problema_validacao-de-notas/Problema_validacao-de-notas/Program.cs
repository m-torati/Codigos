using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_validacao_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== VALIDAÇÃO DE NOTAS ===");
            Console.Write("Digite a sua primeira nota: "); float nota1;
            while (!float.TryParse(Console.ReadLine(), out nota1) || nota1<0 || nota1>10) { Console.Write("Erro. Digite novamente: "); }
            Console.Write("Digite a sua segunda nota: "); float nota2;
            while (!float.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 10) { Console.Write("Erro. Digite novamente: "); }

            float soma = nota1 + nota2;
            float media = soma / 2;
            Console.WriteLine("A média é: " + (Math.Round(media, 2)));

        }
    }
}
