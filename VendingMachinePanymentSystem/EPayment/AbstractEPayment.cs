using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public abstract class AbstractEPayment:AbstractPayment
    {
        protected  IPaymentGateway gateway;

        public IPaymentGateway Gateway
        {
            set { gateway = value; }
        }
    }
}
