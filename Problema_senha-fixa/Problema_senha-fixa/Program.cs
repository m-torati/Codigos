using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_senha_fixa
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que repita a leitura de uma senha
             * até que ela seja válida. Para cada leitura de senha incorreta
             * informada, escrever a mensagem "Senha Invalida! Tente novamente:".
             * Quando a senha for informada corretamente deve ser impressa a mensagem
             * "Acesso Permitido" e o algoritmo encerrado. Considere que a senha 
             * correta é o valor 2002. */

            const string senha = "2002"; // const garante que a variável não irá mudar de valor
            Console.Write("Digite a senha: ");
            string senha_inserida = Console.ReadLine();
            while (senha_inserida != senha)
            {
                Console.Write("Senha Inválida! Tente novamente: ");
                senha_inserida = Console.ReadLine();
            }
            Console.WriteLine("\nAcesso Permitido");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
