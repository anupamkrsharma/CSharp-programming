using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

 namespace list
{   
    class List{
        ArrayList array = new ArrayList();
        
        public object this [int index]{
            get{
                return array[index];
            }
            set{
                array.Add(value);
            }
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter index no");
            
            List list = new List();
            list[0] ="kvs";
            list[1]="govt.ms";
            list[2]="!";
            int x=int.Parse(Console.ReadLine());
                Console.WriteLine("LIST"+ list[x]);
          }
    }
    


}


