using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            // memebr variables
            char[] myCharArr;
            int position;
            string result, myString;
            myString = "This is c# programming";
            myCharArr = new char[30];

            // create output string + operator is used for concat.
            // each + operator creating a new instance of string object.
            // Best practice - try to avoid as much as you can using + operator
            result = "my string = " + myString;
            // checking length
            result += "\n String length is: " + myString.Length;
            // indexOf() - return -1 if no result found
            position = myString.IndexOf('c');
            result += "\n String cotanin 'c' letter at: " + position;
            // find the next index 
            position = myString.IndexOf('c', ++position);
            result += "\n String cotanin 'c' letter at: " + position;

            Console.WriteLine(result);

            // copyTo()
            result += "\n Using CopyTo() method";
            myString.CopyTo(0, myCharArr, 0, 10);

            // using string interpolation c# 6 2015 and up 
            int age = 30;
            string name = "User name";
            string printStr = $"\tHello {name.ToUpper()} your age is {age} years old";
            Console.WriteLine(printStr);



        }
    }
}
