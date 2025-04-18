using Abstract_Factory_Design_Pattern.AbstractFactory;
using Abstract_Factory_Design_Pattern.AbstractProduct;
using Abstract_Factory_Design_Pattern.AbstractProducts;
using Abstract_Factory_Design_Pattern.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.ConcreteFactories
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
