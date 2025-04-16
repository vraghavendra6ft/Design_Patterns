using Factory_Design_Pattern.Factory;
using Factory_Design_Pattern.Interfaces;

namespace Factory_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IPaymentGateway gateway = PaymentGatewayFactory.CreatePaymentGateway("payPal");
            gateway.ProcessingPayment((decimal)100.00);

            Console.ReadKey();
        }
    }
}
