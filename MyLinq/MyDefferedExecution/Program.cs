using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDefferedExecution
{
    class Program
    {
        public static void DefferedExecution()
        {
            int[] myNum = new int[] { 2,3,4,5,66,77,88,99,100};
            // counter
            int i = 0;

            var myEnumeration = from n
                                in myNum
                                select i++;

            // we want to check and see when i variable is evaluated
            foreach (var num in myEnumeration)
            {
                Console.WriteLine("num is:{0}, i = {1}", num, i);
            }
        }
        static void Main(string[] args)
        {
            DefferedExecution();
        }
    }
}
