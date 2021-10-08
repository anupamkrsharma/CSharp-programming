using System;
using System.Text.RegularExpressions;

namespace UserExceptionHandling
{

    class MyException : Exception
    {
        public MyException(string msg) : base(msg)
        {
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n\nEnter a Good String");
                string a = Console.ReadLine();

                // finding a number or digit (0-9) in an input string
                Regex regex = new Regex(@"\d");
                
                // check if any digit found in an input string
                if (regex.IsMatch(a))
                {
                    // custom Exception raising
                    throw new MyException("ERROR! = Found 'number' within a string!. Only character allowed.\n\n");
                }
                else {
                    // custom Exception raising
                    throw new MyException("Perfect!\n\n");

                }


            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
