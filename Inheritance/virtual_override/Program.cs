/*
    Basic program that illustrate the concept of 'virtual' & 'override' in Inheritance
    and idea how they are used!

    It is likely be a readable form that methods in the base class will/may override in 
    respective derived classes
*/

using System;

namespace virtual_override
{
    class Base{

        // Base class constructor
        public Base(){
            Console.WriteLine("Base Class Constructor INVOKED!");
        }

        // Base Class virtual method
        public virtual void Display(){
            Console.WriteLine("Base Class method called!");
        }
    }

    class Derived : Base{       // inhertance

        // Derived class constructor
        public Derived(){
            Console.WriteLine("Derived Class Constructor INVOKED!");
        }

        // Derived class override method 
        public override void Display(){
            Console.WriteLine("Derived Class method called!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nUse of 'virtual' & 'override' concept in Inheritance\n");
            Derived derived = new Derived();
            derived.Display();           
            Console.WriteLine("");
        }
    }
}
