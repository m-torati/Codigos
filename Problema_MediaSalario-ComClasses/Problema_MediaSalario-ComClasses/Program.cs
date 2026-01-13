using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_MediaSalario_ComClasses
{
    class Funcionarios
    {
        public float Salario;
        public string Nome;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();
            Console.WriteLine("Dados do 1º funcionário: ");
            Console.Write("Salário: R$");
            f1.Salario = float.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Dados do 2º funcionário: ");
            Console.Write("Salário: R$");
            f2.Salario = float.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();

            float media = (f1.Salario + f2.Salario) / 2f;
            Console.Clear();
            Console.WriteLine($"A média salarial é de R${media:F2} reais");
            Console.ReadKey();
        }
    }
}
