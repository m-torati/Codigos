using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===TABUADA===");
            Console.WriteLine("De 1 a 10");
            Console.Write("Qual numero deseja ver a tabuada?: "); int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n<=0) { Console.Write("Erro. Digite um número natural de 1 a 10: ");  }
            Console.Clear();
            for (int i = 0; i<11; i++) { Console.WriteLine($"{n}x{i}=" + (n * i)); }
        }
    }
}
