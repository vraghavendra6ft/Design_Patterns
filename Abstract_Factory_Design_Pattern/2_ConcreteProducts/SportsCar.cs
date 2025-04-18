using Abstract_Factory_Design_Pattern.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.ConcreteProducts
{
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Sports car details : ");
        }
    }
}
