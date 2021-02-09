using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory
{
    public  interface IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("this is in Vehicle Mthods");
        }
    }
}
