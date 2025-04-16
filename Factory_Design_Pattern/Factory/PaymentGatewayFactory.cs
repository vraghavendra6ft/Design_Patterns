using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Design_Pattern.ConcreteClasses;
using Factory_Design_Pattern.Interfaces;

namespace Factory_Design_Pattern.Factory
{
    public static class PaymentGatewayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName.ToLower())
            {
                case "paypal":
                    return new PayPal();
                case "stripe":
                    return new Stripe();
                case "creditcard":
                    return new CreditCard();
                default:
                    throw new ArgumentException("Invalid payment gateway specified");
            }
        }
    }
}
