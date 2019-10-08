using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachinePanymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractEPayment ePayment = new CardPaymentSystem();
            //ePayment.Price = 100;
            //ePayment.Gateway= new OcbcPaymentGateway();
            //ePayment.ProcessPayment();

            //AbstractEPayment ePayment = new InternetPaymentSystem();
            //ePayment.Price = 100;
            //ePayment.Gateway = new OcbcPaymentGateway();
            //ePayment.ProcessPayment();

            //AbstractEPayment ePayment = new InternetPaymentSystem();
            //ePayment.Price = 100;
            //ePayment.Gateway = new DbsPaymentGateway();
            //ePayment.ProcessPayment();

            AbstractEPayment ePayment = new InternetPaymentSystem();
            ePayment.Price = 100;
            ePayment.Gateway = new OcbcPaymentGateway();

            if (ePayment.ProcessPayment())
            {
                Console.WriteLine("Done");
            }
            else {
                Console.WriteLine("Failed");
            }
            Console.ReadLine();
        }
    }
}
