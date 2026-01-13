using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Largura_e_Altura_ComClasse
{
    class Retangulo
    {
        public float Altura;
        public float Largura;
        public float Perimetro() { return 2 * (Altura + Largura); }
        public double Diagonal() { return Math.Sqrt((Altura * Altura) + (Largura * Largura)); }
        public float Area() { return Altura * Largura; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.Write("Digite a largura do retângulo: ");
            r.Largura = float.Parse(Console.ReadLine());
            
            Console.Write("Digite a altura do retângulo: ");
            r.Altura = float.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine($"Área: {r.Area():F3}"); // chamo, calculo e imprimo
                                                       // o resultado da função

            Console.WriteLine($"Perímetro: {r.Perimetro():F3}"); // chamo, calculo e imprimo
                                                                 // o resultado da função
            
            Console.WriteLine($"Diagonal: {r.Diagonal():F3}"); // chamo, calculo e imprimo
                                                               // o resultado da função
            Console.ReadKey();
        }
    }
}
