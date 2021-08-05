using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n) ? ");
            char deposito = char.Parse(Console.ReadLine());
            ContaBancaria conta = new ContaBancaria(nome, numero);

            if (conta.CheckDeposit(deposito))
            {
                Console.Write("Entre o valor de deposito inicial $ ");
                conta.Deposit(double.Parse(Console.ReadLine()));
                Console.WriteLine("");
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
            }

            Console.WriteLine("");
            Console.Write("Entre um valor para deposito $ ");
            conta.Deposit(double.Parse(Console.ReadLine()));

            Console.WriteLine("");
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre um valor para saque $ ");
            conta.Withdraw(double.Parse(Console.ReadLine()));

            Console.WriteLine("");
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
