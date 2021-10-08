using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream("load.txt", FileMode.Append, FileAccess.Write)))
                {
                    Console.WriteLine("'load.txt' is opened!\n");
                    Console.WriteLine("Enter the string to write ");
                    string text = Console.ReadLine();
                    sw.WriteLine(text);
                    Console.WriteLine("Saved file!\n");
                }

                //Reading a text file
                string line = "";
                using(StreamReader sr =new StreamReader(new FileStream("load.txt", FileMode.Open, FileAccess.Read)))
                {
                    Console.WriteLine("'load.txt' is opened!\n");
                    while((line = sr.ReadLine())!= null)
                    {
                        Console.WriteLine(line );
                    }
                    Console.WriteLine("\n");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
