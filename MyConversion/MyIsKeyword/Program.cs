using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIsKeyword
{
    // System.Object
    class MyClass1
    {}
    class MyClass2
    { }
    class Program
    {
        static void TestClass(object o)
        {
            // implicit 
            int x = 100;
            long l = x;

            // Member variable
            var myTest = new MyClass1();

            MyClass1 a;
            MyClass2 b;
            if (o is MyClass1) // true or false 
            {
                Console.WriteLine("o is MyClass1");
                a = (MyClass1)o;
            }
            else if (o is MyClass2)
            {
                Console.WriteLine("o is MyClass2");
                b = (MyClass2)o;
            }
            else
            {
                Console.WriteLine("o is nither");
            }

        }
        static void Main(string[] args)
        {
            // MyClass1 myObj10 = new MyClass1();
            var myObj1 = new MyClass1();
            var myObj2 = new MyClass2();
            TestClass(myObj1);
            TestClass(myObj2);
            TestClass("This is string");

        }
    }
}
