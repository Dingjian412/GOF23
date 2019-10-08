using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public class DbsPaymentGateway:IPaymentGateway
    {
        public bool Pay(double selectedItemPrice)
        {
            Console.WriteLine($"DbsPaymentGateway:{selectedItemPrice}");
            return true;
        }
    }
}
