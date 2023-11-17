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

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicles> list = new List<Vehicles>();
            Car car1 = new Car() { HasATrunk = "YEEEPP", HasFourWheels = "I SHOULD HOPE SO"};
            MotorCycle motorcycle1 = new MotorCycle() { HasAHelmet = "Denser than my skull", HasFourWheels = "... it's a motorcycle"};
            Vehicles vehicle1 = new Car() { HasATrunk = "Nope", HasFourWheels = "yes"};
            Vehicles vehicle2 = new MotorCycle() { HasAHelmet = "Noooooo", HasFourWheels = "yes"};

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            list.Add(car1);
            list.Add(vehicle1);
            list.Add(vehicle2);
            list.Add(motorcycle1 ); 

            foreach (var item in list)
            {
                Console.WriteLine("Here are the properties of each Vehicle:");
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Year);
                item.PrintDetails();
            }


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
            vehicle1.DriveAbstract();
            vehicle2.DriveAbstract();
            car1.DriveVirtual();
            car1.DriveAbstract();
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            
            #endregion            
            Console.ReadLine();
        }
    }
}
