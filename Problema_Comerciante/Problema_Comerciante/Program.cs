using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Comerciante
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto,
             * mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de
             * venda das mesmas. Fazer um programa que leia tais dados e determine e escreva quantas mercadorias
             * proporcionaram:*/

            Console.Write("Serão digitados quantos produtos?: "); int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) { Console.Write("Erro. Digite novamente: "); }
            string[] nomes = new string[n];
            float[] preco_Compra = new float[n];
            float[] preco_Venda = new float[n];
            float somaPrecoCompra = 0, somaVenda = 0;
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Produto {i + 1}: ");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                
                Console.Write("Preço de compra: ");
                while (!float.TryParse(Console.ReadLine(), out preco_Compra[i]) || preco_Compra[i] <= 0) { Console.Write("Erro. Digite novamente: "); }
                somaPrecoCompra = somaPrecoCompra + preco_Compra[i];
                
                Console.Write("Preço de venda: ");
                while (!float.TryParse(Console.ReadLine(), out preco_Venda[i]) || preco_Venda[i] <= 0) { Console.Write("Erro. Digite novamente: "); }
                somaVenda = somaVenda + preco_Venda[i];
            }
            float[] lucro = new float[n];
            int somaAbaixo10 = 0, entre10e20 = 0, acimaDe20 = 0;
            for (int i = 0; i < nomes.Length; i++)
            {
                lucro[i] = preco_Venda[i] - preco_Compra[i];

                if (preco_Venda[i] / preco_Compra[i] < 1.1) somaAbaixo10 = somaAbaixo10 + 1;
                else if (preco_Venda[i] / preco_Compra[i] >= 1.1 && preco_Venda[i] / preco_Compra[i] <= 1.2)
                    entre10e20 = entre10e20 + 1;
                else if (preco_Venda[i] / preco_Compra[i] > 1.2) { acimaDe20 = acimaDe20 + 1; }
                //else { Console.Write("Erro"); }
            }
            Console.Clear();
            Console.WriteLine("RELATÓRIO FINAL: ");
            Console.WriteLine($"Lucro abaixo de 10%: {somaAbaixo10:F0}");
            Console.WriteLine($"Lucro entre 10 e 20%: {entre10e20:F0}");
            Console.WriteLine($"Lucro acima de 20%: {acimaDe20:F0}");
            Console.WriteLine($"Valor total de compra: {somaPrecoCompra:C2}");
            Console.WriteLine($"Valor total de venda: {somaVenda:C2}");
            Console.WriteLine($"Lucro total: {somaVenda - somaPrecoCompra:C2}");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
