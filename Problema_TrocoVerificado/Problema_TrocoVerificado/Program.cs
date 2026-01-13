using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_TrocoVerificado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/ Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia. 
            O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto, 
            e o valor em dinheiro dado pelo cliente. Seu programa deve mostrar o valor do troco a ser devolvido 
            ao cliente. Se o dinheiro dado pelo cliente não for suficiente, mostrar uma mensagem informando o 
            valor restante conforme exemplo. /*/

            Console.WriteLine("=== CALULADORA DE TROCO ===");
            Console.Write("Qual é o preço unitário do produto?: ");
            float precounitario;
            while (!float.TryParse(Console.ReadLine(), out precounitario) && precounitario >= 0)
            {
                Console.Write("Valor inválido. Por favor, insira um número válido: ");
            }
            Console.Write("Quantas unidades do produto foram compradas?: ");
            int quantidade;
            while(!int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 0) 
            { 
                Console.Write("Valor inválido. Por favor, insira um número válido: "); 
            }
            float valor_total = precounitario * quantidade;
            Console.Write("Insira o valor para realizar a compra: ");
            float valor_para_pagar;
            while (!float.TryParse(Console.ReadLine(), out valor_para_pagar) && valor_para_pagar > 0) 
            { 
                Console.Write("Valor inválido. Por favor, insira um número válido: "); 
            }
            if (valor_para_pagar<valor_total) { Console.WriteLine("Dinheiro insuficiente. Faltam R$" + (valor_total - valor_para_pagar).ToString("F2")); }
            else if (valor_para_pagar > valor_total) { Console.WriteLine("Troco: R$" + (valor_para_pagar - valor_total).ToString("F2")); }
            else Console.WriteLine("Valor exato recebido. Sem troco.");
            Console.ReadKey();
        }
    }
}
