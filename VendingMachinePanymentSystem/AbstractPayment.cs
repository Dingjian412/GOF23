using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    public abstract class AbstractPayment
    {
        protected double price;
        private double totalMoney;
        public double Price { set { price = value; } }
        public abstract bool ProcessPayment();
    }
}
