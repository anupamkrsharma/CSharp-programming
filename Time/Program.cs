using System;

namespace Time
{
    class Time
    {
        int d = 0, h, m, s;
        public int H{
            get
            {
                return h;
            }
            set
            {
                if(value <= 24)
                {
                    h = value;
                }
                else
                {
                    Console.WriteLine("Hour is not in particular format");
                }
                
            }
        }

        public int M
        {
            get
            {
                return m;
            }
            set
            {
                if (value <= 60)
                {
                    m = value;
                }
                else
                {
                    Console.WriteLine("Minutes is not in particular format");
                }
            }
        }

        public int S
        {
            get
            {
                return s;
            }
            set
            {
                if (value <= 60)
                {
                    s = value;
                }
                else
                {
                    Console.WriteLine("Second is not in particular format");
                }
            }
        }

        public static Time operator -(Time t1, Time t2)
        {
            Time t = new Time();
            if(t1.h <= t2.h){
                t.h = t2.h - t1.h;
            }
            else{
                t.h = t1.h - t2.h;
            }

            if(t1.m <= t2.m){
                t.m = t2.m - t1.m;
            }
            else{
                t.m = t1.m - t2.m;
            }

            if(t1.s <= t2.s){
                t.s = t2.s - t1.s;
            }
            else{            
                t.s = t1.s - t2.s;
            }
          
            return t;
        }

        public static Time operator +(Time tm1, Time tm2){
            Time t = new Time();
            
            t.h = tm1.h + tm2.h;
            t.m = tm1.m + tm2.m;
            t.s = tm1.s + tm2.s;
            if(t.s > 60){
                
                t.s = t.s - 60;
                t.m = t.m + 1;
                if(t.m > 60){
                    t.m = t.m - 60;
                    t.h = t.h + 1;
                }

                if(t.h > 24){
                    t.h = t.h - 24;
                    t.d = t.d + 1;
                }

            }
           
        return t;
        }

        public void Display()
        {
            Console.WriteLine(" Result = "+ d + "day :" + h + "hr : " + m + "min : " + s + "sec");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Time time1 = new Time();
            // time1.H = 15;
            // time1.M = 24;
            // time1.S = 10;
            // Console.WriteLine(" TIME 1 = " + time1.H + " : " + time1.M + " : " + time1.S);

            // Time time2 = new Time();
            // time2.H = 19;
            // time2.M = 4;
            // time2.S = 00;
            // Console.WriteLine(" TIME 2 = " + time2.H + " : " + time2.M + " : " + time2.S);

            // Time result;
            // result = time2 - time1;

            // result.Display();

            Time t1 = new Time();
            Console.WriteLine("Enter Time 1 = H : M : S");
            t1.H = int.Parse(Console.ReadLine());
            t1.M = int.Parse(Console.ReadLine());
            t1.S = int.Parse(Console.ReadLine());

            Time t2 = new Time();
            Console.WriteLine("Enter Time 2 = H : M : S");
            t2.H = int.Parse(Console.ReadLine());
            t2.M = int.Parse(Console.ReadLine());
            t2.S = int.Parse(Console.ReadLine());
        
            Time add ;
            add = t1 + t2;
            add.Display();
        
        }
    }
}
