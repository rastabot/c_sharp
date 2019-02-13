using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRefKeyword
{
    class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("a = " + a.ToString());
            Console.WriteLine("b = " + b.ToString());
            Swap(ref a, ref b);
            Console.WriteLine("a = " + a.ToString());
            Console.WriteLine("b = " + b.ToString());

        }
    }
}
