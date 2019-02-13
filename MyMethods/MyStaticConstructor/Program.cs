using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStaticConstructor
{
    class Car
    {
        // const and readonly
        // const can not be changed
        const string CONNECTION_STRING = "The path to data base";
        public readonly int x = 100; // value can be changed only in deafult constructor 
        // using readonly keyword 
        public static readonly DateTime myDateTime;
        // automatic prop
        public int CarNumber { get; set; }

        public Car()
        {
            x = 200;
        }
        static Car()
        {
            myDateTime = DateTime.Now;
            Console.WriteLine("Static constructor DateTime Now is: {0}", myDateTime.ToLocalTime());
        }
        // instance constructor
        public Car(int carNum)
        {
            this.CarNumber = carNum;
            Console.WriteLine("Car {0} is created ", CarNumber);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCarObj = new Car(100);
            
         }
    }
}
