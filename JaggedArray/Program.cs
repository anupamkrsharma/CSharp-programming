/*
    Basic program that illustrate the concept of JAGGED ARRAYS
*/


using System;

namespace JaggedArray 
{
    class Program
    {
        static void Main(string[] args) 
        {
            // user based inputs

            // inputs for the Number of Jagged Arrays creation
            Console.WriteLine("\n--- ***Implementing Jagged array and finding highest sum*** ---");
            Console.Write("\nEnter number of arrays to be created : ");
            int m = int.Parse(Console.ReadLine());

            // Jagged array
            int[][] array = new int[m][];

            // storing sum of each array
            int[] sum = new int[m];

            Console.WriteLine(" Arrays created! ");

            // Entering elements into each arrays
            for (int i = 0; i < m; i++) 
            {
                Console.Write("\nEnter size of array[{0}] : ", i);
                int n = int.Parse(Console.ReadLine());
                array[i] = new int[n];
                Console.WriteLine("\nEnter elements --> array[{0}] : ", i);
                for (int j = 0; j < n; j++) 
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n***finished entering !***");
            Console.WriteLine("-------------------------");


            // Display the Jagged Arrays formed and stores sum in another separate array (sum[])
            Console.WriteLine("\n\n---------Jagged Arrays------------");
            for (int i = 0; i < m; i++) 
            {
                int index = array[i].Length;
                Console.Write("\n Array[{0}] : ", i);
                for (int j = 0; j < index; j++) 
                {
                    Console.Write(" " + array[i][j]);

                    // Calculating sum of each array
                    sum[i] += array[i][j];
                }
            }


            // Finding which array has Max sum 
            int max = 0;
            Console.WriteLine("\n\n-----------Sum--------------");
            for (int i = 0; i < m; i++) 
            {
                Console.Write("\n Sum of Array[{0}] : {1}", i, sum[i]);
                if (sum[i] > max) 
                {
                    max = sum[i];
                }
            }
            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine(" Highest sum is : {0} ", max);
            Console.WriteLine("-----------------------\n\n");
        }
    }
}