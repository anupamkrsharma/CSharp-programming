/*
    Basic program that illustrate the concept of 'base()' keywords in Inheritance
    and idea how they are used!

    It can be parameterized -> (x,y) or empty parentheses -> (), depending on constructor contructed in the class.
*/

using System;

namespace usingBaseKeyword
{
    class Pen{
        public string name;
        public Pen(string name){
            this.name = name;
        }
    }

    class BallPen: Pen{
        public string color;
        public int price;

        //using 'base(name)' will call the base class parameterised constructor to initialize the name
        public BallPen(string name, string color, int price):base(name){
            this.color = color;
            this.price = price;
        }
        public void Display(){
            Console.WriteLine("Pen's Name   : " + name);
            Console.WriteLine("Pen's color  : " + color);
            Console.WriteLine("Pen's price  : " + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of the Pen  : ");           
            string penname = Console.ReadLine();
            Console.Write("Enter color of the Pen : ");
            string pencolor = Console.ReadLine();
            Console.Write("Enter price of the Pen : ");
            int penprice = int.Parse(Console.ReadLine());

            // instance creation with arguments
            BallPen ballPen = new BallPen(penname, pencolor, penprice);
            ballPen.Display();
        }
    }
}
