using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_Design_Pattern.Interfaces;

namespace FactoryMethod_Design_Pattern.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return MakeProduct();
        }

    }
}
