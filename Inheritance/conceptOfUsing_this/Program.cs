/*
    Basic program that illustrate the concept of 'base()' & 'this()' keywords in Inheritance
    and idea how they are used!

    It can be parameterized -> (x,y) or empty parentheses -> (), depending on constructor contructed in the class.
*/


using System;

namespace conceptOfUsing_this {
    class Base {

        public Base() {
            Console.WriteLine("Base Class Constructor INVOKED!");
        }
    }

    class Derived: Base {
        public int value;

        // using 'base()' the base class constructor gets invoked
    
        public Derived(): base() {
            Console.WriteLine("Derived Class Constructor INVOKED!");
        }

        // using 'this()'the base class constructor gets invoked
        // invoking constructor within the same class by using 'this'
        public Derived(int x): this() {
            value = x;
            Console.WriteLine("Derived Class value = " + value);
        }

    }
    class Program {
        static void Main(string[] args) {
            Derived derived = new Derived(10);
        }
    }
}