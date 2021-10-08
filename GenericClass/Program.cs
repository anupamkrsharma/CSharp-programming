using System;

namespace GenericClass
{
    class Generic<type> where type: IComparable<type>
    {
        public static type[] sort(type[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 1; j < arr.Length; j++)
                {
                    if(arr[j].CompareTo(arr[j - 1]) < 0)
                    {
                        type temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                } 
            }
            return arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {     

            Console.WriteLine("\n*** Use of Generic class & method Concept ***");

            // ---- interger array------------------------
            int[] array =   { 9,1,5,7,6,3,2 };
            Console.Write("\n\nOriginal Array : ");
            foreach(int ele in array){Console.Write(ele + "  ");}

            //generic sort() method int array
            Generic<int>.sort(array);
            Console.Write("\nSorted Array   : ");
            foreach(int ele in array){Console.Write(ele + "  "); }


            // ---- character array------------------------
            char[] b =   { 'X','F','Q','H','M','R' };
            Console.Write("\n\nOriginal Array : ");
            foreach(char ele in b){Console.Write(ele + "  ");}
            
            //generic sort() method for char array
            Console.Write("\nSorted Array   : ");
            foreach(char ele in Generic<char>.sort(b)){Console.Write(ele + "  "); }


            // ---- double array------------------------
            double[] ar ={2.6, 8.6, 5.5, 1.9, 7.2, 0.7};
            Console.Write("\n\nOriginal Array : ");
            foreach(double ele in ar){Console.Write(ele + "  ");}

            //generic sort() method for double array
            Console.Write("\nSorted Array   : ");
            foreach(double ele in Generic<double>.sort(ar)){Console.Write(ele + "  "); }

            Console.WriteLine("\n");
        }
    }
}
