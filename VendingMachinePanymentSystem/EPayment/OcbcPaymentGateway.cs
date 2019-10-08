using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public class OcbcPaymentGateway:IPaymentGateway
    {
        public bool Pay(double selectedItemPrice)
        {
            Console.WriteLine($"OcbcPaymentGateway:{selectedItemPrice}");
            return true;
        }
    }
}
