using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class ContaPoupanca : IConta
    {
        public ContaPoupanca(double balance)
        {
            Balance = balance;
        }

        public double Balance { get; set; }
        public void deposit(double amount)
        {
            Balance += amount;
        }

        public double getSaldo()
        {
            return Balance;
        }

        public void withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
            }
            else
            {
                throw new DomainException("Balance insuficient");
            }
        }
    }
}
