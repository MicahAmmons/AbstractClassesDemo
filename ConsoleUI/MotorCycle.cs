using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class MotorCycle : Vehicles
    {
        public string HasAHelmet { get; set; } = "I should hope so";
        public string HasFourWheels { get; set; } = "NOPE";

        public override void DriveAbstract()
        {
            Console.WriteLine("Vroom Vroom this is the override for MotorCycles");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Vroom Vroom this is the OPTIONAL VIRTUAL Overrride");
        }
        public override void PrintDetails()
        {
            Console.WriteLine(HasAHelmet);
            Console.WriteLine(HasFourWheels);
        }
    }
}


/* 
  * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
  * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
  * Provide the implementations for the abstract methods
  * Only in the Motorcycle class will you override the virtual drive method
 */