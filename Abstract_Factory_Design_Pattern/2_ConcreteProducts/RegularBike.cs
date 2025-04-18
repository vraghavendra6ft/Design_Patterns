﻿using Abstract_Factory_Design_Pattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern.ConcreteProducts
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Regular Bike Details : ");
        }
    }
}
