using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Design_Pattern.Interfaces;

namespace Factory_Design_Pattern.ConcreteClasses
{
    public class PayPal : IPaymentGateway
    {
        public void ProcessingPayment(decimal amount)
        {
            Console.WriteLine("This is PayPal Gateway");
        }
    }
}
