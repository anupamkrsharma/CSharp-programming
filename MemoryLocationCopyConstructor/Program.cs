using System;
using System.Runtime.InteropServices;

namespace Copy_Constructor
{
    class Copy
    {
        public int var1;
        public int var2;
        public string word;

        public Copy()
        {
            var1 = 60;
            var2 = 22;
            word = "Copy";
            //    GCHandle handle1 = GCHandle.Alloc(word, GCHandleType.WeakTrackResurrection);
            //    int address1 = (int)GCHandle.ToIntPtr(handle1).ToInt64();
            //    Console.WriteLine("Default Constructor --Address of string 'word'       = " + address1);
            unsafe
            {
                fixed(char *p = word)
                {
                    Console.WriteLine(" word " + ((int)p).ToString());
                }
               
            }
        }

        public Copy(Copy obj2)
        {
            var1 = obj2.var1;
            var2 = obj2.var2;
            word = obj2.word;
            //GCHandle handle2 = GCHandle.Alloc(word, GCHandleType.WeakTrackResurrection);
            //int address2 = (int)GCHandle.ToIntPtr(handle2).ToInt64();
            //Console.WriteLine("Copy constructor    --Address of string 'word'       = " + address2);

            //GCHandle handle3 = GCHandle.Alloc(obj2.word, GCHandleType.WeakTrackResurrection);
            //int address3 = (int)GCHandle.ToIntPtr(handle3).ToInt64();
            //Console.WriteLine("Copy constructor    --Address of string 'obj2.word'  = " + address3);

            unsafe
            {
                fixed (char* p1 = obj2.word)
                {
                    Console.WriteLine(" obj2.word cc  " + ((int)p1).ToString());
                }
                fixed (char* p2 = word)
                {
                    Console.WriteLine(" word cc  " + ((int)p2).ToString());
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Copy object1 = new Copy();
            Copy object2 = new Copy(object1);


            Console.WriteLine("object1 = " + object1.var1 + " " + object1.var2 + " " + object1.word);
            Console.WriteLine("object2 = " + object2.var1 + " " + object2.var2 + " " + object2.word);

            //GCHandle handle1 = GCHandle.Alloc(object1.word, GCHandleType.WeakTrackResurrection);
            //GCHandle handle2 = GCHandle.Alloc(object1.word, GCHandleType.WeakTrackResurrection);

            //int address1 = (int)GCHandle.ToIntPtr(handle1).ToInt64();
            //int address2 = (int)GCHandle.ToIntPtr(handle2).ToInt64();
            //Console.WriteLine("object1 = " + address1);
            //Console.WriteLine("object2 = " + address2);
            ////Console.WriteLine("Hello World!");

            object1.word = "hello_world";
            Console.WriteLine("object1 = "+object1.word);
            Console.WriteLine("object1 = " + object2.word);



        }
    }
}
