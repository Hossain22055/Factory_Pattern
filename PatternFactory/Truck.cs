using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory
{
    public class Truck:IVehicle
    {
        public Truck()
        {
            Console.WriteLine("This is a new Truck" );
        }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving");
        }
    }
}
