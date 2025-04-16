using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_Design_Pattern.ConcreteClasses;
using FactoryMethod_Design_Pattern.FactoryMethod;
using FactoryMethod_Design_Pattern.Interfaces;

namespace FactoryMethod_Design_Pattern
{
    public class TitaniumFactoryMethod : CreditCardFactory
    {
        public override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Titanium();
            return creditCard;
        }
    }
}
