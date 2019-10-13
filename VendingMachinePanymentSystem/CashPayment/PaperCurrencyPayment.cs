using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public class PaperCurrencyPayment : AbstractCashPayment
    {
        public override bool ProcessPayment()
        {
           Console.WriteLine("PaperCurrencyPayment");
            return true;
        }
    }
}
