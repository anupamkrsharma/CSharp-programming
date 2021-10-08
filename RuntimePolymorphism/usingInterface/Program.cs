using System;

namespace usingInterface
{
    interface Area{
        double Evalute(double x);
    }

    class Circle: Area{
        public double Evalute(double x){
            return (Math.PI*x*x);
        }
    }
    class Square: Area{
        public double Evalute(double x){
            return (x*x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area area;
            area = new Circle(); 
            Console.WriteLine("Area of Circle = {0}",area.Evalute(5));

            area = new Square();
            Console.WriteLine("Area of Square = {0}",area.Evalute(5));

        }
    }
}
