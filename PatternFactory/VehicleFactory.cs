using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelcount)
        {
            switch (wheelcount)
            {
                case 2:
                    return new Truck();
                    break;
                case 4:
                    return new Car();
                    break;
                default:
                    return new Car();
            }
        }
    }
}
