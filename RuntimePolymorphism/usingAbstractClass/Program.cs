using System;

namespace usingAbstractClass
{
// abstract class
public abstract class Person{
    public string Name{set; get;}
    public Person(){
        Console.WriteLine("Abstract Class PERSON");
    }
    public abstract void Display();
}

class Local : Person{
    public override void Display(){
        Console.WriteLine("Local Name : {0}",Name);
    }
}

class Foreigner : Person{
    public override void Display(){
        Console.WriteLine("Forigner Name : {0}",Name);
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            /*
                Run Time Polymorphism is implemented using Abstract Class "Person"
            */

            // making reference of the base class "Person"
            Person person;

            // Insatanciating reference to Local Class
            person = new Local();
            person.Name = "Anupam Sharma";
            person.Display();

            Console.WriteLine(" ");

            // Insatanciating reference to Foreigner Class
            person = new Foreigner();
            person.Name = "XYZ ABC ";
            person.Display();
            
           
        }
    }
}
