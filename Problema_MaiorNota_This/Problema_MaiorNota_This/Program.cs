using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_MaiorNota_This
{
    class Aluno
    {
        public string Nome;
        public double Nota;

        public Aluno(double nota, string nome)
        {
            this.Nota = nota;
            this.Nome = nome;
        }
        public void MaiorNota(Aluno outro)
        {
            if (this.Nota > outro.Nota)
                Console.WriteLine($"{this.Nome} tem a maior nota: {this.Nota}");
            else if (outro.Nota > this.Nota)
                Console.WriteLine($"{outro.Nome} tem a maior nota: {outro.Nota}");
            else
                Console.WriteLine("As duas notas são iguais");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do primeiro aluno: ");
            string nome1 = Console.ReadLine();
            Console.Write("Digite sua nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Aluno a1 = new Aluno(nota1, nome1);

            Console.Write("Digite o nome do segundo aluno: ");
            string nome2 = Console.ReadLine();
            Console.Write("Digite sua nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Aluno a2 = new Aluno(nota2, nome2);

            // Chama a comparação: "this" dentro de MaiorNota será a1
            a1.MaiorNota(a2);

            Console.ReadKey();
        }
    }
}


