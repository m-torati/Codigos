using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Leia a hora inicial e a hora final de um jogo. 
             * A seguir calcule a duração do jogo, sabendo que o mesmo 
             * pode começar em um dia e terminar em outro, 
             * tendo uma duração mínima de 1 hora e máxima de 24 horas. 
             *
             * Exemplo:
             * Hora inicial: 16
             * Hora final: 2
             * O JOGO DUROU 10 HORA(S)
             */
            Console.Write("Hora inicial: ");
            int horaInicial;
            while (!int.TryParse(Console.ReadLine(), out horaInicial) || horaInicial<0) Console.Write("Por favor, insira uma hora válida: ");
            Console.Write("Hora final: ");
            int horaFinal;
            while(!int.TryParse(Console.ReadLine(), out horaFinal) || horaFinal<0) Console.Write("Por favor, insira uma hora válida: ");
            int duracao=0;
            if (horaInicial>horaFinal) duracao = horaFinal - horaInicial + 24;
            else if (horaFinal>horaInicial) duracao = horaFinal - horaInicial;
            else duracao = 24;
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
