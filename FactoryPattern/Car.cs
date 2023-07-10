using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public void Drive() 
        {
            Console.WriteLine(" Car Requirements:"); 
            Console.WriteLine();
            Console.WriteLine("Must be 17 years and older,\n Driver License\n  Training Courses");
        }
    }
}
