using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyICloneable
{
    public class Coffee : ICloneable
    {
        int weight, temprature;
        double price;
        public Coffee(int _weight, int _temp, double _price)
        {
            this.weight = _weight;
            this.temprature = _temp;
            this.price = _price;
        }
        public override string ToString()
        {
            return string.Format("weight is: {0}, Temp is:{1}, price is:{2}", 
                weight, temprature, price);
        }

        // shallow copy
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        // deep copy
        //public object Clone()
        //{
        //    return new Coffee(this.weight, this.temprature, this.price);
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCoffeeObj = new Coffee(1, 22, 3.5);
            var myCoffeeObj2 = myCoffeeObj.Clone();
            Console.WriteLine(myCoffeeObj);
            Console.WriteLine(myCoffeeObj2);

            // Heap and stack 
            if (myCoffeeObj.Equals(myCoffeeObj2))
            {
                Console.WriteLine("Same reference");
            }
            else if (myCoffeeObj2 == myCoffeeObj)
            {
                Console.WriteLine("Same content");
            }


        }
    }
}
