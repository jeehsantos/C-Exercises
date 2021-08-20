using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    interface IConta
    {
        void deposit(double amount);
        void withdraw(double amount);
        double getSaldo();
    }
}
