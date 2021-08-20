using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class ContaCorrente : IConta
    {
        public double Balance { get; private set; }
        public double Tarif { get; set; }

        public ContaCorrente(double balance, double tarif)
        {
            Balance = balance;
            Tarif = tarif;
        }

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
                Balance = Balance - amount - Tarif;
            }
            else
            {
                throw new DomainException("Balance insuficient");
            }
        }
    }
}
