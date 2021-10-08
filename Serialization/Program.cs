using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization
{
  
    [Serializable]
    class Info
    {
        public string Name { get; set; }

    }


    class Program
    {
      
        static void Main(string[] args)
        {
            Info info = new Info();
            info.Name = Console.ReadLine();
            
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream("abc.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, info);
            }
            
            using (FileStream fs = new FileStream("abc.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                 Info info1 = (Info)bf.Deserialize(fs);
                 Console.WriteLine("Deserialized object\n " + info1.Name);
            }
            
            

        }

    }
}
