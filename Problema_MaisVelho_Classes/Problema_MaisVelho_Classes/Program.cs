using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Problema_MaisVelho_Classes
{
    class Pessoas
    {
        public string nome;
        public int idade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa: ");
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            // Pessoas = tipo da variável que criei através da classe
            // p1/p2 = objeto do tipo Pessoas
            // new Pessoas = cria o objeto na memória

            Console.Write("Nome: ");
            p1.nome = Console.ReadLine(); // entrando com os dados
            Console.Write("Idade: ");
            p1.idade = Int32.Parse(Console.ReadLine()); // entrando com os dados

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine(); // entrando com os dados
            Console.Write("Idade: ");
            p2.idade = Int32.Parse(Console.ReadLine()); // entrando com os dados

            if (p1.idade > p2.idade) Console.WriteLine($"{p1.nome} é mais velho(a) que {p2.nome}");
            else if (p1.idade < p2.idade) Console.WriteLine($"{p2.nome} é mais velho(a) que {p1.nome}");
            else Console.WriteLine("Ambos(as) têm a mesma idade");
        }
    }
}
