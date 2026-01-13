using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Problema_pares_consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O programa deve ler um valor inteiro X indefinidas vezes. 
             * (O programa irá parar quando o valor de X for igual a 0). 
             * Para cada X lido, imprima a soma dos 5 pares consecutivos 
             * a partir de X, inclusive o X , se for par. Se o valor de entrada for 4, 
             * por exemplo, a saída deve ser 40, que é o resultado da operação: 
             * 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, 
             * a saída deve ser 80, que é a soma de 12+14+16+18+20. */

            while (true)
            {
                Console.Write("Digite um número inteiro positivo (0 para sair): ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0) Console.Write("Erro. Digite novamente: ");

                if (n == 0) break;
                int primeiroPar;
                if (n % 2 == 0) primeiroPar = n; // começa do próprio n
                else primeiroPar = n + 1; // começa do próximo número
                int soma = 0; // reinicia a soma para cada entrada
                for (int i = 0; i < 5; i++) soma += primeiroPar + i * 2;
                Console.WriteLine($"Soma = {soma}");
            }
        }
    }
}
