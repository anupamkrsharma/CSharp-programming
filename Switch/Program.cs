using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice :\n 1: helo\n 2: bye\n 3: World\n");
            int n = int.Parse(Console.ReadLine());
            switch(n){
                case 1: break;
                case 2: Console.WriteLine("helo from case 1");
                        goto case 2;
                        //break;
                case 3: Console.WriteLine("bye from case 2");
                        //goto case 3;
                        break;
                case 4: Console.WriteLine("World from case 3");
                        break;
            }
        }
    }
    
}
