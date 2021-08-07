using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string nome, double salary)
        {
            Id = id;
            Nome = nome;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += (Salary * (percentage / 100.0));
        }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Nome
                   + " ,"
                   + Salary.ToString("F2");
        }
    }
}
