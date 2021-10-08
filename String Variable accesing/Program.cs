using System;

namespace String_Variable_accesing
{
    class Access
    {
        //public string word;
        public int[] arr =new int[2];
        public Access()
        {
            //word = "hello, I m a simple word!";
            arr[0] = 5;
        }

        public Access(Access obj)
        {
            //word = obj.word;
            arr[0] = obj.arr[0];


        }
    }
    class Program
    {
          static void Main(string[] args)
          {
            Access object1 = new Access();
            Console.WriteLine(" Access string 'Word' from object1      = " + object1.arr[0] + "\n");

            Access object2 = new Access(object1);
            Console.WriteLine(" Access string 'Word' from object2      = " + object2.arr[0] + "\n\n");

            // Changing value of string 'word'
            //object1.word = "String Manupilated !!";
            object1.arr[0] = 10;

            // Access string 'word' with different objects
            Console.WriteLine(" After manupilation    object1.word     = " + object1.arr[0] + "\n");

            Console.WriteLine(" After manupilation    object2.word     = " + object2.arr[0] + "\n\n"); // value of string doesnot changed!


        }
    }
}
