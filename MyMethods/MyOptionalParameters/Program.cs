using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOptionalParameters
{
    class MyOptionalParameters
    {
        private string name;
        public MyOptionalParameters(string Name = "Constructor name")
        {
            this.name = Name;
        }
        // method that will get optional and required arguments
        public void OptionalParams(int requiredInt, string optionalStr = "My Str", int y = 100)
        {
            Console.WriteLine("requiredInt {0}, optionalStr {1}, y {2}", requiredInt, optionalStr, y);
        }
        static void Test()
        { }
        static void Test(string str)
        { }
        static void Test(string str, string myStr)
        { }
        public static void TestOptional(string str = "str", string myStr = "Test")
        { }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var myObj = new MyOptionalParameters();
            myObj.OptionalParams(100," Test ", 200);
            MyOptionalParameters.TestOptional("");
        }
    }
}
