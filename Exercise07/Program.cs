using System;
using System.Collections.Generic;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ? ");
            int nEmployee = int.Parse(Console.ReadLine());
            List<Employee> employee = new List<Employee>();
            for (int i = 0; i < nEmployee; i++)
            {
                Console.WriteLine("Employee #{0}: ", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employee.Add(new Employee(id, name, salary));
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = employee.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage ");
                double increase = double.Parse(Console.ReadLine());
                emp.increaseSalary(increase);
            }
            else
            {
                Console.WriteLine("This Id does not exist !");
            }
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee x in employee)
            {
                Console.WriteLine(x);
            }
        }
    }
}
