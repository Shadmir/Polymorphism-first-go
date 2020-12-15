using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car:Vehicle
    {
        public override void PrintVehicle()
        {
            Console.WriteLine("I'm a car of make {0}, model {1} and colour {2}.", make, model, colour);
        }
    }
}
