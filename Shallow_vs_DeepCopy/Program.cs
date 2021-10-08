/*
    Basic program that illustrate the concept of SHALLOW COPY & DEEP COPY 
    and idea how they are used!
*/


using System;

namespace Shallow_vs_DeepCopy
{
    class University{
        public string university;
        public University(string university){
            this.university = university;
        }
    }
    class Student{
        public string Name{ get; set;}
        public University university_name;

        public Student ShallowCopy(){
            return (Student)this.MemberwiseClone();
        }

        public Student DeepCopy(){
            Student obj = (Student)this.MemberwiseClone();
            obj.university_name = new University(university_name.university);
            obj.Name = Name;
            return obj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            
            Student s1 =new Student();
            s1.Name = "Anupam Sharma";
            s1.university_name = new University("Jammu University");


            Console.WriteLine("\n----------------------------------------------------------------");
            Console.WriteLine("------------------     *** Shallow Copy ***   ------------------");
            Console.WriteLine("----------------------------------------------------------------");

            Student s2 = s1.ShallowCopy();
            Console.WriteLine("\n-------------------- Original Values --------------------");
            Console.WriteLine("Object student1 : \n Name       = {0}\n University = {1}",s1.Name,s1.university_name.university);
            Console.WriteLine("\nObject student2 : \n Name       = {0}\n University = {1}",s2.Name,s2.university_name.university);

            
            s1.Name = "Ram S Kumar";
            s1.university_name.university = "Delhi University";
            Console.WriteLine("\n-------- After Modifications in Object 'student1' --------");    
            Console.WriteLine("Object student1 : \n Name       = {0}\n University = {1}",s1.Name,s1.university_name.university);
            Console.WriteLine("\nObject student2 : \n Name       = {0}\n University = {1}",s2.Name,s2.university_name.university);

            Console.WriteLine("\n\n----------------------------------------------------------------");
            Console.WriteLine("--------------------    *** Deep Copy ***   --------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Student s3 = s1.DeepCopy();
            Console.WriteLine("\n-------------------- Original Values --------------------");
            Console.WriteLine("Object student1 : \n Name       = {0}\n University = {1}",s1.Name,s1.university_name.university);
            Console.WriteLine("\nObject student3 : \n Name       = {0}\n University = {1}",s3.Name,s3.university_name.university);

            s1.Name = "Vijay Kumar ";
            s1.university_name.university = "Nehru University";
            Console.WriteLine("\n-------- After Modifications in Object 'student1' --------");
            Console.WriteLine("Object student1 : \n Name       = {0}\n University = {1}",s1.Name,s1.university_name.university);
            Console.WriteLine("\nObject student3 : \n Name       = {0}\n University = {1}",s3.Name,s3.university_name.university);


        }
    }
}
