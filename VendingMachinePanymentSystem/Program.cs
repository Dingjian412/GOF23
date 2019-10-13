using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachinePanymentSystem.CashPayment;

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

            AbstractEPayment payment = new InternetPaymentSystem();
            payment.Price = 100;
            payment.Gateway = new OcbcPaymentGateway();


            //AbstractPayment payment = new PaperCurrencyPayment();
            //ePayment.Price = 100;

            //AbstractPayment payment = new CoinPayment();
            //payment.Price = 100;

            if (payment.ProcessPayment())
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
