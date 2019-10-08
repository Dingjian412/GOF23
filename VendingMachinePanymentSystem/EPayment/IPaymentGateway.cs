using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public interface IPaymentGateway
    {
        bool Pay(double selectedItemPrice);
    }
}
