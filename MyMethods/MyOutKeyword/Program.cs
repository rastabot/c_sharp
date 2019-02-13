using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOutKeyword
{
    class Program
    {
        static string GetStringValues(out string fName, out string lName)
        {
            Console.Write("Enter first name:");
            fName = Console.ReadLine();
            Console.Write("Enter last name:");
            lName = Console.ReadLine();

            return fName + " " + lName;

        }
        static void Main(string[] args)
        {
            string first, last, full;
            full = GetStringValues(out first, out last);
        }
         
    }
}
