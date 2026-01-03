using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Problema_ContaBancaria_POO
{
    class ContaBancaria
    {
        public string Nome { get; set; } // nome pode ser alterado
        public int Numero { get; private set; } // numero da conta não pode ser alterado
        public float Saldo { get; private set; } // saldo inicial da conta
                                                 // apenas pode ser alterado
                                                 // por saque ou depósito

        private const int TaxaSaque = 5; // definindo a taxa como uma constante 

        public ContaBancaria(string nome, int numero, float saldo) // construtor 
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Saldo = saldo;
        }
        public float Deposito(float deposito) { return Saldo += deposito; }
        public float Saque(float saque)
        {
            double valorTotal = saque + TaxaSaque;
            return Saldo -= (float)valorTotal;
        }
        public override string ToString() { return ($"Conta {Numero}, Titular {Nome}, Saldo: R${Saldo:F2}"); }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Número da conta: "); int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0) { Console.Write("Erro. Tente novamente: "); }

            Console.Write("Haverá depósito inicial (s/n)?: "); char opcao;
            while (!char.TryParse(Console.ReadLine().ToLower(), out opcao) || opcao != 's' && opcao != 'n') { Console.Write("Erro. Digite novamente: "); }

            float saldo = 0;

            if (opcao == 's')
            {
                Console.Write("Informe o saldo inicial: R$");
                while (!float.TryParse(Console.ReadLine(), out saldo) || saldo < 0) { Console.Write("Erro. Digite novamente: R$"); }
            }
            else if (opcao == 'n') saldo = 0;

            ContaBancaria c = new ContaBancaria(nome, numero, saldo);
            Console.Clear();
            Console.WriteLine(c);
            Console.Write("\nEntre com um valor para depósito: R$"); float deposito;
            while (!float.TryParse(Console.ReadLine(), out deposito) || deposito < 0) { Console.Write("Erro. Digite novamente: R$"); }
            c.Deposito(deposito);
            Console.WriteLine("\n" + c);
            Console.Write("\nEntre um valor para saque: R$"); float saque;
            while (!float.TryParse(Console.ReadLine(), out saque) || saque < 0) { Console.Write("Erro. Digite novamente: R$"); }

            c.Saque(saque);
            Console.WriteLine("\n" + c);
        }
    }
}
