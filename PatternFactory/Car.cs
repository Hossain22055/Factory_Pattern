using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory
{
    public class Car:IVehicle
    {
        public Car()
        {

        }
        public void Drive()
        {
            Console.WriteLine("this is in car" );
        }
    }
}
