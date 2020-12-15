using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Vehicle
    {
        public string make;
        public string model;
        public string colour;

        public Vehicle()
        {
            Console.WriteLine("Enter your vehicle's make (i.e. Ford)");
            make = Console.ReadLine();
            Console.WriteLine("Enter your vehicle's model (i.e. Fiesta)");
            model = Console.ReadLine();
            Console.WriteLine("Enter your vehicle's colour (i.e. Greenish-purple)");
            colour = Console.ReadLine();
        }
        public virtual void PrintVehicle()
        {
            Console.WriteLine("I'm a generic vehicle with make {0}, model {1} and colour {2}.", make, model, colour);
        }
    }
}
