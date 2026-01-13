using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_aumento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma empresa vai conceder um aumento percentual de 
            salário aos seus funcionários dependendo de quanto 
            cada pessoa ganha, conforme tabela ao lado. Fazer um 
            programa para ler o salário de uma pessoa, daí mostrar 
            qual o novo salário desta pessoa depois do aumento, 
            quanto foi o aumento e qual foi a porcentagem de aumento. */
            Console.WriteLine("SE NECESSÁRIO, USE A VÍRGULA AO INVÉS DO PONTO");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Qual é o seu salário atual? R$ ");
            float salario;
            while(!float.TryParse(Console.ReadLine(), out salario) || salario < 0)
            {
                Console.Write("Valor inválido. Por favor, insira um salário válido: R$ ");
            }
            float novo_salario = 0;
            if (salario<=1000) novo_salario = salario * 1.20f;
            else if (salario > 1000 && salario <= 3000) novo_salario = salario * 1.15f;
            else if (salario > 3000 && salario <= 8000) novo_salario = salario * 1.10f;
            else novo_salario = salario * 1.05f;
            Console.WriteLine("Seu novo salário é R$" + novo_salario.ToString("F2"));
            Console.WriteLine("Uma diferença de R$" + (novo_salario - salario).ToString("F2"));
            Console.WriteLine("Percentual: " + (((novo_salario / salario) - 1)*100).ToString("F0") + "%" );
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
