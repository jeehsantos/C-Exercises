using Exercise25.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary $ ");
            double salary = double.Parse(Console.ReadLine());
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');

                    list.Add(new Employee() { Name = fields[0], Email = fields[1], Salary = double.Parse(fields[2]) });
                }
            }


            Console.Write($"Email of people whose salary is more than ${salary.ToString("F2")}");
            var e1 = list.Where(q => q.Salary > salary).OrderBy(q => q.Email).Select(q => q.Email);
            var e2 = list.Where(x => x.Name[0] == 'M').Sum(obj => obj.Salary);
            Console.WriteLine();
            foreach (string p in e1)
            {
                Console.WriteLine(p);
            }
            Console.Write("Sum of salary of people whose name starts with 'M' $ " + e2);

        }
    }
}
