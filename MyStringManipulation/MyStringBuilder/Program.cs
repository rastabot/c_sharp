using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StringBuilder()
            StringBuilder mySb = new StringBuilder("ABC", 50);
            // using Append() to add chars 
            mySb.Append(new char[] { 'D','E','F'});
            mySb.AppendFormat("GHI {0}////{1}", 'J', 'K');
            Console.WriteLine("{0} chars are : {1}", mySb.Length, mySb.ToString());
            // insert new elements
            mySb.Insert(4, "This is additional string");
            Console.WriteLine("{0} chars are : {1}", mySb.Length, mySb.ToString());

            mySb.Replace('G', 'g');
            Console.WriteLine("{0} chars are : {1}", mySb.Length, mySb.ToString());




        }
    }
}
