/*
    Basic program that illustrate the concept of PROPERTIES
    and idea how they are used!
*/


using System;

namespace Properties
{
    class Properties{
        private string name;
        private int age;

        public string Name {
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public int Age{
            get{
                return age;
            }
            set{
                if(value < 18){
                    Console.WriteLine("You are below 18");
                    
                }
                else{
                    age = value;
                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Properties properties = new Properties();
            Console.Write("\n Enter your name : ");
            properties.Name = Console.ReadLine();

            Console.Write(" Enter your age : ");
            properties.Age =int.Parse(Console.ReadLine());

            Console.WriteLine("\nName = " + properties.Name);
            Console.WriteLine("Age = " + properties.Age);
        }
    }
}
