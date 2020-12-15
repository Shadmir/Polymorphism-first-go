using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ListVehicles
    {
        
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            while(true)
            {
                Menu();
            }
            void Menu()
            {
                Console.WriteLine("Would you like a to: \n" +
                    "1: Add a car. \n" +
                    "2: Add a motorcycle. \n" +
                    "3: List all vehicles. \n" +
                    "4: Quit.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Car car = new Car();
                        vehicleList.Add(car);
                        break;
                    case "2":
                        Motorbike motorbike = new Motorbike();
                        vehicleList.Add(motorbike);
                        break;
                    case "3":
                        ListAllVehicles();
                        break;
                    case "4":
                        Console.WriteLine("Press enter to quit...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid inut.... enter a number 1-4");
                        Menu();
                        break;
                }
            }
            void ListAllVehicles()
            {
                foreach (var vehicle in vehicleList)
                {
                    vehicle.PrintVehicle();
                }
            }
        }
    }
}
