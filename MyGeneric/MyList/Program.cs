using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<string> myCarList = new List<string>();

            Console.WriteLine("Capacity is: {0} ", myCarList.Capacity);

            myCarList.Add("Car 1");
            myCarList.Add("Car 2");
            myCarList.Add("Car 3");

            foreach (string c in myCarList)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Count is: {0} ", myCarList.Count);

            Console.WriteLine("Find elements is: {0} ", myCarList.Contains("Car 2"));

            Console.WriteLine("Insert is: {0} ");
            myCarList.Insert(2, "New Car");
            foreach (string c in myCarList)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Remove is: {0} ");
            myCarList.Remove("Car 1");
            foreach (string c in myCarList)
            {
                Console.WriteLine(c);
            }
        }

       
    }
}
