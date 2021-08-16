using Exercise12.Entities;
using System;
using System.Collections.Generic;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employee = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numberEmploy = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numberEmploy; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                if(outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    Employee.Add(new OutsourceEmployee(name, hours, valueHour, addCharge));
                }
                else
                {
                    Employee.Add(new Employee(name, hours, valueHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
                foreach (Employee employees in Employee)
                {
                    Console.WriteLine(employees.Name + "- $ "+ employees.payment().ToString("F2"));
                }
            
        }
    }
}
