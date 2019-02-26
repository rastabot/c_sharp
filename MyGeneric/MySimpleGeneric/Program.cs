using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleGeneric
{
    public class MyClass
    {
        public void Display(int value)
        {
            Console.WriteLine(value);
        }
        public void Display(double value)
        {
            Console.WriteLine(value);
        }
        public void Display(string value)
        {
            Console.WriteLine(value);
        }
        // using generic 
        public void DisplayGeneric<T>(T value)
        {
            Console.WriteLine(value);
        }
        public void DisplayGenericTest<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine("{0}, {1}", value1, value2);
        }
        public void DisplayGenericDemo<MyType>(string str, MyType myVar)
        {
            Console.WriteLine("{0}, {1}", str, myVar);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var myObj = new MyClass();
            myObj.Display(10.4);
            myObj.Display("Test");

            myObj.DisplayGeneric<int>(20);
            myObj.DisplayGeneric<string>("Test");

            myObj.DisplayGeneric(5.5);

            myObj.DisplayGenericTest<int, string>(10, "Test");

            myObj.DisplayGenericDemo<int>(myVar: 100, str: "Test");
        }
    }
}
