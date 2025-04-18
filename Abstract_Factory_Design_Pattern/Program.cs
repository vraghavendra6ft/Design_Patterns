using Abstract_Factory_Design_Pattern.AbstractFactory;
using Abstract_Factory_Design_Pattern.AbstractProduct;
using Abstract_Factory_Design_Pattern.AbstractProducts;
using Abstract_Factory_Design_Pattern.ConcreteFactories;

namespace Abstract_Factory_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory vehicleFactory = new RegularVehicleFactory();
            
            IBike regularBike = vehicleFactory.CreateBike();
            regularBike.GetDetails();

            ICar regularCar = vehicleFactory.CreateCar();
            regularCar.GetDetails();

            IVehicleFactory vehicleFactory1 = new SportsVehicleFactory();

            IBike sportsBike = vehicleFactory1.CreateBike();
            sportsBike.GetDetails();

            ICar sportsCar = vehicleFactory1.CreateCar();
            sportsCar.GetDetails();

            Console.ReadKey();
        }
    }
}
