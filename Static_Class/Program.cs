using System;

namespace Static_Class
{
    // Evaluation class
    class Eval
    {
        public int var1;

        //constructor
        public Eval() => var1 = Abc.sixty + Abc.one;

        //Display Evaluation Function
        public void EvalDisplay() => Console.WriteLine("evaluation = " + var1);

    }

    //Static Class
    public static class Abc
    {
        //Static data members
        public static int sixty;
        public static int one;
     

        //static constructor
        //        Static constructors can‘t contain any access modifiers.
        //        Static constructors can‘t be defined with arguments.
        //        Static constructors can‘t access the non-static data members.
        static Abc()
        {
            sixty = 60;
            one = 1;
            Console.WriteLine("Static Constructor INVOKED!");
        }
       
    }

      class Program
    {
        static void Main(string[] args)
        {
        
        /*
            to check the result of static class, uncomment the below statements 
        */

           //Program o = new();
           //Abc obj = new();
           Eval obj = new();
           Console.WriteLine("sixty variable  = " + Abc.sixty + " & one variable = " + Abc.one);
            obj.EvalDisplay();
        }
    }
}
