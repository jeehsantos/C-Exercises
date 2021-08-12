using Exercise10.Entities;
using Exercise10.Entities.Enums;
using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();
            Department dept = new Department(department);
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker newWorker = new Worker(name, level, baseSalary, dept);
            Console.Write("How many contracts to this worker ? ");
            int nContracts = int.Parse(Console.ReadLine());

            for(int i = 0; i < nContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valueHour, duration);
                newWorker.addContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter the month and year to calculate income (MM/YYYY): ");
            string dateIncome = Console.ReadLine();
            int month = int.Parse(dateIncome.Substring(0, 2));
            int year = int.Parse(dateIncome.Substring(3));
            double income = newWorker.income(year, month);
            Console.WriteLine("Name: "+ newWorker.Name.ToString());
            Console.WriteLine("Department: "+ newWorker.Department.Name);
            Console.WriteLine($"Income for {dateIncome}: "+ income.ToString());

        }
    }
}
