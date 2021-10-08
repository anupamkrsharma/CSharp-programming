/*
    Basic program that illustrate the concept of 'new' keywords in Inheritance
    and idea how they are used!

    It is generally when you are using a class defined by someone else and you are inheriting it, 
    and you want to override that method in your derived class, then 'new' keyword comes into play 
    to hide the parent class method that will override in derived class without throwing any warning 
    or error
    its basically hide the base class method in derived class.
*/


using System;

namespace new_inOverriding
{
    class Base{

        // Base class constructor
        public Base(){
            Console.WriteLine("Base Class Constructor INVOKED!");
        }

        // Base Class method
        public void Display(){
            Console.WriteLine("Base Class method called!");
        }
    }

    class Derived : Base{       // inhertance

        // Derived class constructor
        public Derived(){
            Console.WriteLine("Derived Class Constructor INVOKED!");
        }

        // Derived class override method using 'new' keyword or hide base class method
        public new void Display(){
            Console.WriteLine("Derived Class method called!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nUse of 'new' to hide base class method while overriding\n");
            Derived derived = new Derived();
            derived.Display();  
            Console.WriteLine("");
        }
    }
}
