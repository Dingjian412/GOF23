using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public class InternetPaymentSystem:AbstractEPayment
    {
        public override bool ProcessPayment()
        {
            Console.WriteLine("InternetPaymentSystem:");
            return gateway.Pay(base.price);
        }
    }
}
