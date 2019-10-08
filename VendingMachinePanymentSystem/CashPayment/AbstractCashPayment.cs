using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public class AbstractCashPayment : AbstractPayment
    {
        public override bool ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}
