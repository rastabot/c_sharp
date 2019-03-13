using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImmediateExecution
{
    class Program
    {
        public static void ImmediateExecution()
        {
            int[] myNum = new int[] { 2, 3, 4, 5, 66, 77, 88, 99, 100 };
            // counter
            int i = 0;

            // Immediate excetion use one of the following:
            // ToArray()
            // ToList()
            //ToDictionary()
            var myEnumeration = (from n
                                in myNum
                                select i++).ToArray<int>();

            // we want to check and see when i variable is evaluated
            foreach (var num in myEnumeration)
            {
                Console.WriteLine("num is:{0}, i = {1}", num, i);
            }
        }
        static void Main(string[] args)
        {
            ImmediateExecution();
        }
    }
}
