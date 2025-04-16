using FactoryMethod_Design_Pattern.Interfaces;

namespace FactoryMethod_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ICreditCard creditCard = new PlatinumFactoryMethod().CreateProduct();

            if (creditCard != null) {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
        }
    }
}
