using System;

namespace SealedMethod
{
    class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Virtual method");
        }
    }
    

    class DerivedClass : Parent
    {
        // Now the display method have been sealed and can't be overridden  
        public override sealed void Display()
        {
            Console.WriteLine("Sealed method is called");
        }
    }

    //public class ThirdClass : DerivedClass
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Here we try again to override display method which is not possible and will give error");
    //    }
    //}
    class Program
    {
        
        static void Main(string[] args)
        {
            DerivedClass ob1 = new DerivedClass();
            ob1.Display();
            Console.ReadLine();
        }
    }
}
