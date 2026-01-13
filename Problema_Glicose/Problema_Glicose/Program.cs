using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Glicose
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/Fazer um programa para ler a quantidade de glicose 
            no sangue de uma pessoa e depois mostrar na tela a 
            classificação desta glicose de acordo com a tabela de 
            referência ao lado /*/
            Console.WriteLine("=== CLASSIFICAÇÃO DA SUA GLICOSE ===");
            Console.WriteLine("Se necessário, use a vírgula ao invés do ponto");
            Console.Write("\nDigite a medida da glicose: ");
            float glicose;
            while (!float.TryParse(Console.ReadLine(), out glicose)) Console.Write("Inválido, digite a quantidade novamente: ");
            if (glicose <= 100) Console.WriteLine("Sua glicose está normal");
            else if (glicose > 100 && glicose <= 140) Console.WriteLine("Elevado");
            else Console.WriteLine("Diabético");
            Console.ReadKey();
        }
    }
}
