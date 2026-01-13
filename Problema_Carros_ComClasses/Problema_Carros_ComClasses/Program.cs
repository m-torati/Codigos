using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Carros_ComClasses
{
    class Carros
    {
        public string Nome;
        public int Ano;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carros c1 = new Carros();
            Carros c2 = new Carros();
            Console.WriteLine("Dados do 1º carro: ");
            Console.Write("Nome: ");
            c1.Nome = Console.ReadLine();
            Console.Write("Ano: ");
            c1.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do 2º carro: ");
            Console.Write("Nome: ");
            c2.Nome = Console.ReadLine();
            Console.Write("Ano: ");
            c2.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (c1.Ano > c2.Ano) Console.WriteLine($"{c1.Nome} {c1.Ano} é mais novo que o {c2.Nome} {c2.Ano}");
            else if (c1.Ano < c2.Ano) Console.WriteLine($"{c2.Nome} {c2.Ano} é mais novo que o {c1.Nome} {c1.Ano}");
            else Console.WriteLine("Ambos são do mesmo ano");
            Console.ReadKey();
        }
    }
}
