using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_DadosFuncionarios_ComClasses
{
    class Funcionarios
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido() 
        { 
            return SalarioBruto - Imposto; 
        }
        public void AumentarSalario(double porcentagem) 
        { 
            SalarioBruto += SalarioBruto * (porcentagem / 100.0); 
        }
        public override string ToString() 
        { 
            return ($"{Nome}, R${SalarioLiquido():F2}"); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios func = new Funcionarios();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"{func.Nome}, R$" + func);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            
            func.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: " + func);
        }
    }
}
