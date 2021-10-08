using System;

namespace OperatorOverloading
{
    class Complex
    {
        public double real, imaginary;
     
        public static Complex operator +(Complex x, Complex y)
        {
            Complex c = new();
            c.real = x.real + y.real;
            c.imaginary = x.imaginary + y.imaginary;
            return c;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            Complex c = new();
            c.real = x.real - y.real;
            c.imaginary = x.imaginary - y.imaginary;
            return c;
        }

        public static Complex operator *(Complex x, Complex y)
        {
            Complex c = new();
            c.real = x.real * y.real;
            c.imaginary = x.imaginary * y.imaginary;
            return c;
        }

        public static Complex operator /(Complex x, Complex y)
        {
            Complex c = new();
            c.real = x.real / y.real;
            c.imaginary = x.imaginary / y.imaginary;
            return c;
        }

        public void Dis()
        {
            Console.WriteLine("\nResult = {0} + i({1})", real,imaginary);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nEnter Complex terms like (a1 + ib1)");
            Complex a = new Complex();
            Console.Write("Real   a1    = ");
            a.real = double.Parse(Console.ReadLine());
            Console.Write("Imaginary b2 = ");
            a.imaginary = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Complex terms like (a2 + ib2)");
            Complex b = new Complex();
            Console.Write("Real  a2     = ");
            b.real = double.Parse(Console.ReadLine());
            Console.Write("Imaginary b2 = ");
            b.imaginary = double.Parse(Console.ReadLine());

            Complex C;
            C = a + b;
            Console.WriteLine("\nAddition       = {0} + i({1})", C.real, C.imaginary);

            C = a - b;
            Console.WriteLine("Subtraction    = {0} - i({1})", C.real, C.imaginary);

            C = a * b;
            Console.WriteLine("Multiplication = {0} * i({1})", C.real, C.imaginary);

            C = a / b;
            Console.WriteLine("Division       = {0} / i({1})\n\n", C.real, C.imaginary);

        }
    }
}
