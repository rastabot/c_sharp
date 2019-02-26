using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericClass
{
    // define a class that will take 2 arguments 
    public class Car<T1, T2>
    {
        // generic automatic properties
        public T1 carId { get; set; }
        public T2 carSpeed { get; set; }

        // generic classic properties
        private T1 myVar;
        public T1 MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCarObj = new Car<char, double>();
            var myCarObj1 = new Car<int, string>();
            myCarObj1.carId = 1234;
            myCarObj1.carSpeed = "100";

        }
    }
}
