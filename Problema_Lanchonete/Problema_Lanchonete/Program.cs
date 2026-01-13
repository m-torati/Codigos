using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Uma lanchonete possui vários produtos. Cada produto possui um código 
             * e um preço. Você deve fazer um programa para ler o código e a 
             * quantidade comprada de um produto (suponha um código válido), e daí 
             * informar qual o valor a ser pago, com duas casas decimais, conforme 
             * tabela de produtos ao lado. */
            Console.Write("Digite o código do produto (1 a 5): ");
            int codigo;
            while (!int.TryParse(Console.ReadLine(), out codigo) || codigo < 1 || codigo > 5) Console.Write("Código inválido. Digite um número inteiro: ");
            Console.Write("Digite a quantidade comprada: ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade<0) Console.Write("Quantidade inválida. Digite um número inteiro: ");
            float valorTOTAL = 0;
            if (codigo == 1) valorTOTAL = quantidade * 5f;
            else if (codigo == 2) valorTOTAL = quantidade * 3.50f;
            else if (codigo == 3) valorTOTAL = quantidade * 4.80f;
            else if (codigo == 4) valorTOTAL = quantidade * 8.90f;
            else if (codigo == 5) valorTOTAL = quantidade * 7.32f;
            Console.WriteLine("Valor total da compra: R$" + valorTOTAL);
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
