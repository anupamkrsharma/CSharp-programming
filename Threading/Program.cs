using System;
using System.Threading;

namespace Threading
{
    class ThreadClass
    {
        public static void Method()
        {
            Console.WriteLine("\n\n\tMethod Thread Start => {0}", Thread.CurrentThread);

            for (int i = 1; i <= 50000; i++)
            {
                Console.WriteLine("\t  Method Thread " + i);
                //Thread.Sleep(800);
            }

            Console.WriteLine("\tMethod Thread End => {0}", Thread.CurrentThread);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Main Thread start => {0}", Thread.CurrentThread);
            
            // Thread Creation and Call
            Thread TM = new(new ThreadStart(ThreadClass.Method));
            TM.Start();
            
            for (int i = 1; i <= 50000; i++)
            {
                Console.WriteLine("\t  Main Thread " + i);
                //Thread.Sleep(800);
            }


            //TM.Join();        // this will keep the Main thread in waiting untill the TM thread completes

            Console.WriteLine();
            Console.WriteLine(" Main Thread end => {0}", Thread.CurrentThread);
            Console.WriteLine(" Method Thread end => {0}", TM.IsAlive);
            Console.WriteLine(" Main Thread end => {0}", Thread.CurrentThread.IsAlive);

        }
    }
}



