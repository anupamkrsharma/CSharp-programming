using System;

namespace Delegates
{
    delegate void delegateStatus(string status);

    class Worker
    {
        public Worker()
        {
            Console.WriteLine("\nUse of Delegate\n");
        }

        public double Process(double a, double b)
        {
            return (a * b);
        }
        public void StatusPrint(string status)
        {
            Console.WriteLine(status);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
             * Use of delegates as Printing Status 
            */

            // class instantiation
            Worker work = new Worker();

            // delegate instantiation and method with same signature as parameter
            delegateStatus s = new delegateStatus(work.StatusPrint);

            // delegate invoke
            s("Processing Multiplication");

            double result = work.Process(50.3, 94.205);

            // delegate invoke
            s("Result = " + result.ToString() + "\n");

        }
    }
}
