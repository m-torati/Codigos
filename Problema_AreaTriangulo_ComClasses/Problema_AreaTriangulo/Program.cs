using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problema_AreaTriangulo
{
    class Triangulo
    {
        // public = atributo que pode ser acessado no código principal
        public double A;
        public double B;
        public double C;

        // criação de um método (função dentro de uma classe) para calcular a área do triângulo

        public double CalcularArea() // não coloca nenhum parâmetro dentro
                                     // dos parenteses neste caso,
                                     // porque já está dentro da classe
        {
            double p = (A + B + C) / 2f;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os lados de dois triângulos, 
             * em seguida, mostrar a área dos dois triângulos 
             * e imprimir resposta dizendo qual área é maior 

            Necessário usar a Fórmula de Heron */

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.Clear();
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY) Console.WriteLine("Maior área: X");
            else if (areaY > areaX) Console.WriteLine("Maior área: Y");
            else Console.WriteLine("As áreas são iguais");
        }
    }
}

