using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Dardo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/ No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir. 
            Você deve criar um programa para, dadas as medidas das três tentativas de lançamento, informar qual 
            foi a maior /*/
            Console.WriteLine("=== COMPARADOR DE DISTÂNCIAS ===");
            Console.Write("Digite a primeira distância do dardo (em metros): ");
            float distancia1;
            while(!float.TryParse(Console.ReadLine(), out distancia1)) {
                Console.Write("Entrada inválida. Por favor, digite um número válido para a distância: ");
            }
            Console.Write("Digite a segunda distância do dardo (em metros): ");
            float distancia2;
            while (!float.TryParse(Console.ReadLine(), out distancia2)) {
                Console.Write("Entrada inválida. Por favor, digite um número válido para a distância: ");
            }
            Console.Write("Digite a terceira distância do dardo (em metros): ");
            float distancia3;
            while (!float.TryParse(Console.ReadLine(), out distancia3)) {
                Console.Write("Entrada inválida. Por favor, digite um número válido para a distância: ");
            }
            float maior = distancia1;
            if (distancia1 == distancia2 && distancia3 == distancia2) Console.WriteLine("Todas as distâncias são iguais.");
            if (distancia2>distancia1) maior = distancia2;
            if (distancia3>distancia2) maior = distancia3;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"A MAIOR DISTÂNCIA DO DARDO FOI DE {maior:F2} METROS");
        }
    }
}
