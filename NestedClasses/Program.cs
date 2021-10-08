/*
    Basic program that illustrate the concept of NESTED CLASSES 
    and idea how they are used!
*/

using System;

namespace NestedClasses
{
    class OuterClass{
        public void OuterDisplay(){
            Console.WriteLine("Outer class method called! ");
        }

        public class InnerClass{
            public void InnerDisplay(){
               Console.WriteLine("Inner class method called! "); 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Outer Class object creation
            OuterClass outer_obj= new OuterClass();

            // Inner Class object creation
            OuterClass.InnerClass inner_obj = new OuterClass.InnerClass();

            // calling Inner Class method
            inner_obj.InnerDisplay();

            // callig Outer Class method
            outer_obj.OuterDisplay();

            Console.WriteLine("");
        }
    }
}
