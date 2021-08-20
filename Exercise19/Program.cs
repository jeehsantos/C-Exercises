using System;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente c1 = new ContaCorrente(500.00, 1.50);
                ContaPoupanca p1 = new ContaPoupanca(500.00);

                c1.withdraw(50.00);
                GeradorExtratos.GerarExtrato(c1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
