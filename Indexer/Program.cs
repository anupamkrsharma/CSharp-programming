/*
    to Run this in linux firstly required : '.Net Core'
    then cmd as follows to run the code
    - dotnet build
    - dotnet run  
 */

using System;

namespace Indexer
{
    class Student_22 {
        int rollno_22;
        string name_22, course_22;

        public Student_22() {
            Console.WriteLine("Example of Indexer used !");
            Console.WriteLine("Object created : 'student'\n");
        }

        // creating a indexer to set and get the record of student
        // type 'object' used 
        public object this[int index] {

            set {
                if (index == 0) {           // rollno
                    rollno_22 = (int)value;
                }
                else if (index == 1) {      // name
                    name_22 = (string)value;
                } 
                else if (index == 2) {      // course
                    course_22 = (string)value;
                }
            }

            get {
                if (index == 0) {           // rollno
                    return rollno_22;
                } 
                else if (index == 1) {      // name
                    return name_22;
                } 
                else if (index == 2) {      // course
                    return course_22;
                }

                // returning 'null' if index is out of range
                return null;
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("");

            // initialize object
            Student_22 student_22 = new Student_22();                        

            //Taking values from the user as using indexing format
            Console.Write("'student[0]' Enter Rollno : ");           
            student_22[0] = int.Parse(Console.ReadLine());
            Console.Write("'student[1]' Enter Name   : ");
            student_22[1] = Console.ReadLine();
            Console.Write("'student[2]' Enter Course : ");
            student_22[2] = Console.ReadLine();

            // Display result 
            Console.WriteLine("\n\n---Result Fetched !---\n");
            Console.WriteLine("Rollno : " + student_22[0]);
            Console.WriteLine("Name   : " + student_22[1]);
            Console.WriteLine("Course : " + student_22[2]);
        }
    }
}
