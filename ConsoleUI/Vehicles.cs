using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicles 
    {

        public string Year { get; set; } = "2020";
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vroom Vroom this is the default");
        }
        public abstract void PrintDetails();

    }
}


/*
 * Create an abstract class called Vehicle
 * The vehicle class shall have three string properties Year, Make, and Model
 * Set the defaults to something generic in the Vehicle class
 * Vehicle shall have an abstract method called DriveAbstract with no implementation
 * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */