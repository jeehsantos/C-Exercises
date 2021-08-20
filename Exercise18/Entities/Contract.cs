using System;
using System.Collections.Generic;

namespace Exercise18.Entities
{
    class Contract
    {
        public DateTime ContractDate { get; set; }
        public int Number { get; set; }
        public double TotalValue { get; set; }
        public List<Installments> Installments { get; set; } = new List<Installments>();

        public Contract()
        {
        }

        public Contract(DateTime contractDate, int number, double value)
        {
            ContractDate = contractDate;
            Number = number;
            TotalValue = value;
        }

        public void AddInstallment(Installments installments)
        {
            Installments.Add(installments);
        }
    }
}
