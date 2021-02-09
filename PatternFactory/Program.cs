using System;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = VehicleFactory.GetVehicle(2);
            vehicle.Drive();
        }
    }
}
