using System;

namespace MultiCast_Delegate
{
    public delegate void delegateMethod(int a, int b);
    class Arthematic
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("\n\nTHE ADD IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            delegateMethod delAdd = new delegateMethod(Arthematic.Add);
            delegateMethod delSub = new delegateMethod(Arthematic.Sub);
            delegateMethod delMul = new delegateMethod(Arthematic.Mul);
            delegateMethod delDiv = new delegateMethod(Arthematic.Div);

            delegateMethod arth = delAdd + delSub + delMul + delDiv;
            arth.Invoke(20, 5);
            Console.WriteLine();
            arth = delAdd - delSub;
            arth(22, 7);
            Console.WriteLine();

        }
    }
}
