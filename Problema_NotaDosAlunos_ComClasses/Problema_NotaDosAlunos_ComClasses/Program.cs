using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_NotaDosAlunos_ComClasses
{
    class Aluno
    {
        public float Notas1;
        public float Notas2;
        public float Notas3;

        public float SomaNotas()
        {
            return Notas1 + Notas2 + Notas3;
        }
        public float Media()
        {
            return SomaNotas() / 3f;
        }
        public void VerificarAprovacao()
        {
            float Somatorio = SomaNotas();
            float media = Media();
            Console.Clear();
            if (media >= 60) Console.WriteLine($"APROVADO, MÉDIA DE {media:F2} PONTOS");
            else Console.WriteLine($"REPROVADO, FALTARAM {180-Somatorio:F2} PONTOS PARA PASSAR");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite abaixo a nota de cada trimestre: ");
            Console.Write("1º trimestre (0 a 100): "); // nota 1
            aluno.Notas1 = float.Parse(Console.ReadLine());
            Console.Write("2º trimestre (0 a 100): "); // nota 2
            aluno.Notas2 = float.Parse(Console.ReadLine());
            Console.Write("3º trimestre (0 a 100): "); // nota 3
            aluno.Notas3 = float.Parse(Console.ReadLine());
            aluno.VerificarAprovacao();
        }
    }
}
