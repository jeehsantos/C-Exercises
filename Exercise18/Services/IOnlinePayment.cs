﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18.Services
{
    interface IOnlinePayment  
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
