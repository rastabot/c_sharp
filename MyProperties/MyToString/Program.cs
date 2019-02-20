using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToString
{
    public class MyClass
    {
        string pName = ""; // by default getting length of 0 index - and ref to memory address
        string pLastName = string.Empty; // by default getting length of 0 index - and ref to memory address
        string pAddress = null; // null refernce no value 

        public string Name { get; set; }
        public int Age { get; set; }

        // ToString() Override
        public override string ToString()
        {
            return "My Class Details: " + Name + " " + Age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            string str = x.ToString();
            Console.WriteLine(str);

            var myObj = new MyClass();
            Console.WriteLine("{0}----{1}", myObj.Name, myObj.Age);
            Console.WriteLine(myObj);
            Console.WriteLine();
        }
    }
}
