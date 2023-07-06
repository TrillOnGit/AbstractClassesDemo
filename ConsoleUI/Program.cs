using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            

            
            // Create a list of Vehicle called vehicles
            List<Vehicle> garage = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car motorolla = new Car
            {
                Year = "2001",
                Make = "Samswell",
                Model = "Turbo200",
                HasTrunk = true
            };
            Motorcycle hudson = new Motorcycle
            {
                Year = "2021",
                Make = "Charley Davidson",
                Model = "New Edge",
                HasSideCar = true
            };

            Vehicle truck = new Car
            {
                Year = "2010",
                Make = "Dodge",
                Model = "Marksman",
                HasTrunk = true
            };
            Vehicle bullDozer = new Motorcycle
            {
                Year = "1992",
                Make = "Marks",
                Model = "Land Squisher 900",
                HasSideCar = false
            };
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            garage.Add(motorolla);
            garage.Add(hudson);
            garage.Add(truck);
            garage.Add(bullDozer);
            // Call each of the drive methods for one car and one motorcycle

            foreach (var vehicle in garage)
            {
                Console.WriteLine($"Current Model: {vehicle.Model}");
                Console.WriteLine("=========================");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("-------------------------");
            }
            #endregion            
            //Console.ReadLine();
        }
    }
}
