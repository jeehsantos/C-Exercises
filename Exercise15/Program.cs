using Exercise15.Entities;
using System;
using System.Collections.Generic;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int qtyPayers = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= qtyPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Helth expeditures: ");
                    double expeditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, expeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");
            foreach (Person p in list)
            {
                Console.WriteLine(p.Name + ": $" + p.payTaxes().ToString("F2"));
                sum += p.payTaxes();
            }
            Console.WriteLine();
            Console.WriteLine("Total taxes: $ " + sum.ToString("F2"));

        }
    }
}
