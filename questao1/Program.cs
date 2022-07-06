using System;
using System.Globalization;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;


            Console.Write("Entre o número da conta: ");
           int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroConta, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double segundoDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deoposito(segundoDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            
        }
    }
}
