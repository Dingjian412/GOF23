﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem.CashPayment
{
    public class CoinPayment : AbstractCashPayment
    {
        public override bool ProcessPayment()
        {
            Console.WriteLine("CoinPayment");
            return true;
        }
    }
}
