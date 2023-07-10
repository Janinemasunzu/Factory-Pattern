using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle: IVehicle
    {
        public void Drive() 
        {
            Console.WriteLine(" Motorcycle Requirements:");
            Console.WriteLine();
            Console.WriteLine("Must be 21 years and older,\n Motorcycle License,\n  Training Courses");
        }
    }
    
}
