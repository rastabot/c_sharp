using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using type conversion");
            short num1 = 10000, num2 = 10000;
            // Explicit cast into short (allow loss of data)
            short answer = (short)Add(num1, num2);

            Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);

            NarrowResult();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowResult()
        {
            int a = 100;
            string myA = a.ToString();
            Console.WriteLine(myA.GetType());

            // int x = (double)5.5;
            byte myByte = 0;
            int myInt = 200;
            // Explicit 
            myByte = (byte)myInt;
            Console.WriteLine("value of myByte is: {0}", myByte);

            byte myTestByte = 0;
            int myTestInt = 100;
            myTestByte = Convert.ToByte(myTestInt);
            Console.WriteLine("value of myByte is: {0}", myTestByte);
        }
    }
}
