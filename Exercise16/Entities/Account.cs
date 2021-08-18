using Exercise16.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance > amount && WithdrawLimit > amount)
            {
                Balance -= amount;
            }else if(WithdrawLimit < amount)
            {
                throw new DomainException("The amount  exceeds withdraw limit.");
            }
            else
            {
                throw new DomainException("You do not have enough balance to withdraw the amount selected");
            }
        }
    }
}
