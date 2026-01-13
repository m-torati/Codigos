using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Aprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler um conjunto de N nomes de alunos,
             * bem como as notas que eles tiraram no 1º e 2º semestres. 
             * Cada uma dessas informações deve ser armazenada em um vetor.
             * Depois, imprimir os nomes dos alunos aprovados, considerando 
             * aprovados aqueles cuja média das notas seja maior ou igual a 6.0 (seis). */

            Console.WriteLine("=== APROVADO OU REPROVADO?? ===");
            Console.Write("Quantos alunos serão digitados?: "); int n; // determinando indiretamente
                                                                       // o tamanho dos vetores que
                                                                       // serao criado
            while (!int.TryParse(Console.ReadLine(), out n)||n<=0) { Console.Write("Erro. Digite novamente: "); } // entrada e validação
                                                                                                                  // dos dados
            float[] notaPRIMEIRO = new float[n];
            float[] notaSEGUNDO = new float[n];
            string[] nomes = new string[n];

            for (int i = 0; i<notaPRIMEIRO.Length; i++) {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Dados do {i + 1}º aluno");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                
                Console.Write("Primeira nota do semestre: ");
                while (!float.TryParse(Console.ReadLine(), out notaPRIMEIRO[i]) || notaPRIMEIRO[i]<0 || notaPRIMEIRO[i] > 10) { Console.Write("Erro. Digite novamente: "); }
                
                Console.Write("Segunda nota do semestre: ");
                while (!float.TryParse(Console.ReadLine(), out notaSEGUNDO[i]) || notaSEGUNDO[i]<0 || notaPRIMEIRO[i] > 10) { Console.Write("Erro. Digite novamente: "); }
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("\nAluno(s) aprovado(s): ");
            bool aprovado = false;
            for (int i = 0; i<notaSEGUNDO.Length;i++) {
                float media = (notaPRIMEIRO[i] + notaSEGUNDO[i]) / 2.0f;
                if (media>=6f) {
                    if (!aprovado)
                    {
                        Console.WriteLine("\nAluno(s) aprovado(s):");
                        aprovado = true;
                    }
                    Console.WriteLine(nomes[i]);
                }
            }
            if (!aprovado) Console.WriteLine("TODOS REPROVADOS");
        }
    }
}
