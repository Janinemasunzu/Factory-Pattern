using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine(" Truck Requirements:");
            Console.WriteLine();
            Console.WriteLine("Must be 21 years and older,\n CDL License\n  Training Courses, Endorsements");
        }
    }
}