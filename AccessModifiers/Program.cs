/*
    Basic program that illustrate the concept of different types of ACCESS MODIFIERS 
    and idea how they are used!
*/

using System;

namespace AccessModifiers
{
    // Base Class
    public class A{
        // declare variable with all access modifiers
        private string private_var;
        protected string protected_var;
        public string public_var;
        internal string internal_var;

        // Base Class Constructor
        public A(){
            private_var   = "Private variable";
            protected_var = "Protected variable";
            public_var    = "Public variable";
            internal_var = "Internal variable";

            Console.WriteLine("\n*** A Class constructor Invoked!! ***");
            Console.WriteLine("Scope of \"{0}\" is in Class 'A' only", private_var);
        }
    }
    // Derived Class inherits Base Class
    class B : A{
        // Dervied Class Constructor
        public B(){
            Console.WriteLine("\n*** B Class constructor Invoked!! ***");
            Console.WriteLine("Scope of \"{0}\" is in Class 'A' & 'B' only",protected_var);
        }

    }

    //Main
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            // Object Creation and initialization
            B obj = new B();

            Console.WriteLine("Scope of \"{0}\" is through a same file", obj.internal_var);
            Console.WriteLine("Scope of \"{0}\" is throughout the program", obj.public_var);
        }
    }
}
