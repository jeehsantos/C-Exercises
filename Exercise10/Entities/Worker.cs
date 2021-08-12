using Exercise10.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void removeContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }

            return sum;
        }
    }
}
