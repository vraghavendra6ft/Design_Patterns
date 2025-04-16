using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_Design_Pattern.Interfaces;

namespace FactoryMethod_Design_Pattern.ConcreteClasses
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
