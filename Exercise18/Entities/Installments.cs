using System;

namespace Exercise18.Entities
{
    class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments()
        {
        }

        public Installments(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                   + " - "
                   + "$ "
                   + Amount.ToString("F2");
        }
    }
}
