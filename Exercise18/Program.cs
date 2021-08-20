using Exercise18.Entities;
using Exercise18.Services;
using System;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numberContract= int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime dateContract = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double valueContract = double.Parse(Console.ReadLine());
            Console.Write("Number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract newContract = new Contract(dateContract, numberContract, valueContract);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(newContract, months);


            Console.WriteLine("Installments: ");
            foreach (Installments installments in newContract.Installments)
            {
                Console.WriteLine(installments);
            }
        }
    }
}
