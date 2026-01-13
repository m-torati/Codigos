using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_MaiorEmenor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Elabore um exercício em que o usuário preencha uma 
             * matriz 3x4 e o sistema encontre o maior e o menor 
             * valor presentes, informando também suas posições 
             * (linha e coluna). */
            // Obs.: optei por deixar o usuário escolher a dimensão da matriz

            Console.Write("Quantas linhas terá a matriz?: "); int linhas;
            while(!int.TryParse(Console.ReadLine(), out linhas) || linhas<=0) { Console.Write("Erro. Digite um número válido: ");  } // entrada e
                                                                                                                                     // validação
                                                                                                                                     // dos dados
            Console.Write("Quantas colunas terá a matriz?: "); int colunas;
            while (!int.TryParse(Console.ReadLine(), out colunas) || colunas <= 0) { Console.Write("Erro. Digite um número válido: "); } // entrada e
                                                                                                                                         // validação
                                                                                                                                         // dos dados

            int[,] matriz = new int[linhas, colunas];
            for (int i = 0; i<linhas;i++)
            {
                for (int j = 0; j<colunas;j++)
                {
                    Console.Write($"Elemento [{i},{j}]:");
                    while(!int.TryParse(Console.ReadLine(), out matriz[i,j])) { Console.Write("Erro. Digite novamente: ");  }
                }
            }

            int maior = matriz[0, 0];
            int menor = matriz[0, 0];
            int linhaMaior = 0, colunaMaior = 0;
            int linhaMenor = 0, colunaMenor = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                        linhaMenor = i;
                        colunaMenor = j;
                    }
                }
            }
            Console.WriteLine($"\nMaior valor: {maior} (linha {linhaMaior}, coluna {colunaMaior})");
            Console.WriteLine($"Menor valor: {menor} (linha {linhaMenor}, coluna {colunaMenor})");
        }
    }
}
