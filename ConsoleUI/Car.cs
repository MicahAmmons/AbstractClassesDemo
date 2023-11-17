using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicles
    {
        public string HasATrunk { get; set; } = "Yes";
        public string HasFourWheels { get; set; } = "Yes";
        public override void DriveAbstract()
        {
            Console.WriteLine("Vroom Vroom - this is the override for Cars");
        }

        public override void PrintDetails()
        {
            Console.WriteLine(HasATrunk);
            Console.WriteLine(HasFourWheels);
        }
    }
}
