//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/private-constructors

/*
    Basic program that illustrate the concept of STATIC & PRIVATE CONSTRUCTOR 
    and idea how they are used!
*/

using System;

namespace Static_and_Private_Constructor
{
    class Shape
    {
        public static int myvar1;
        private static int myvar2;


        static Shape()
        {
            myvar1 = 5;
            myvar2 = 10;
            Console.WriteLine("\nStatic constructor INVOKED!");
        }

        private Shape()
        {
            Console.WriteLine("Private constructor");
        }

        public static int Myvar2 { get => myvar2; set => myvar2 = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        /*
            to check the result of private constructor, uncomment the below statements 
        */

            //Shape s = new();
            Console.WriteLine(Shape.myvar1 + " " + Shape.Myvar2 + "\n");
            //Console.WriteLine(Shape.myvar1 + " " + Shape.myvar2 + " " + s.myvar3);
        }
    }
}
