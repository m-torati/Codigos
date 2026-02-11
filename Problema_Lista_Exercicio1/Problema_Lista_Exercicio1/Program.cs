using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_Lista_Exercicio1
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            List<int> ID = new List<int>();
            List<double> salarios = new List<double>();

            Console.WriteLine("Se desejar finalizar o programa\nescreva 'zero' no nome");
            string nome;
            int id;
            double salario = 0;
            int soma = 1;
            while(true)
            {
                Console.WriteLine($"\n#Funcionário {soma}");
                Console.Write("Digite o nome do funcionário: ");
                nome = Console.ReadLine(); // entrando com a variável
                if (nome == "zero") break;
                nomes.Add(nome); // adicionando na lista

                Console.Write("Digite o ID do funcionário: ");
                while (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || Analisar(id, ID)) { Console.WriteLine("Erro. Digite novamente: "); }
                ID.Add(id);
                // validação e entrada dos dados


                Console.Write("Digite o salário do funcionário: R$");
                while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0) { Console.WriteLine("Erro. Digite novamente: "); }
                salarios.Add(salario);
                Console.WriteLine();
                soma++;
            }

            double aumento = 1;
            double salarioNovo = 1;
            Console.Clear();

            for (int i = 0; i < nomes.Count; i++) Console.WriteLine($"#{ID[i]}: {nomes[i]} --> R${salarios[i]}");
            Console.WriteLine("-----------------------------------");
            Console.Write("Digite o ID desejado: "); int CODIGO2;
            while (!int.TryParse(Console.ReadLine(), out CODIGO2) || CODIGO2 <= 0 || !Analisar(CODIGO2, ID)) { Console.WriteLine("Erro. Digite novamente: "); }
            Console.Write("Qual será a porcentagem do aumento salarial?: ");
            while (!double.TryParse(Console.ReadLine(), out aumento) || aumento < 0) { Console.WriteLine("Erro. Digite novamente: "); }


            for (int i = 0; i < ID.Count; i++)
            {
                if (CODIGO2 == ID[i])
                {
                    salarioNovo = ((aumento / 100) + 1) * salarios[i];
                    salarios[i] = salarioNovo;
                }
            }

            for (int i = 0; i < nomes.Count; i++) Console.WriteLine($"#{ID[i]}: {nomes[i]} --> R${salarios[i]}");
            

            Console.ReadKey();
        }
        static bool Analisar(int ID, List<int> codigo)
        {
            if (codigo.Contains(ID)) { return true; } // verificar se o ID é o mesmo ou não
            else return false;
        }
    }
}
