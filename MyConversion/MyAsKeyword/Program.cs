using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAsKeyword
{
    class A
    {}
    class B
    { }
    class Program
    {
        static void Main(string[] args)
        {
            object[] myArr = new object[6];
            myArr[0] = new A();// ToString()
            myArr[1] = new B();
            myArr[2] = "my string";
            myArr[3] = 123; // int32
            myArr[4] = 123.4;
            myArr[5] = null;

            for (int i = 0; i < myArr.Length; ++i)
            {
                string str = myArr[i] as string;
                if (str != null)
                {
                    Console.WriteLine("Value is " +  str + "");
                }
                else
                {
                    Console.WriteLine("Not a string");
                }


            }

        }
    }
}
