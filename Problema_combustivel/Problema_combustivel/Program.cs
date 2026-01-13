using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um posto de combustíveis deseja determinar qual 
             * de seus produtos tem a preferência de seus clientes. 
             * Escreva um algoritmo para ler o tipo de combustível 
             * abastecido, codificado da seguinte forma: 
             * 1.Álcool
             * 2.Gasolina 
             * 3.Diesel 
             * 4.Fim
             
             * Caso o usuário informe um código inválido (fora da faixa de 1 a 4) 
             * deve ser solicitado um novo código (até que seja válido). 
             * O programa será encerrado quando o código informado for o número 4, 
             * devendo então mostrar a mensagem "MUITO OBRIGADO", bem 
             * como as quantidades de cada combustível.*/

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int opcao = -1;
            while (opcao!=4)
            {
                Console.Clear();
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                try { opcao = int.Parse(Console.ReadLine()); }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Entrada inválida.");
                    opcao = -1;
                }
                switch (opcao)
                {
                    case 1: alcool++; break;
                    case 2: gasolina++; break;
                    case 3: diesel++; break;
                    case 4: break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
