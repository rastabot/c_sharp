using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamedParams
{
    class Program
    {
        static int CalcData(int x, int y, string str = "Test")
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            CalcData(str: "New value", y: 100, x: 200);
            CalcData(y: 400, x: 200);

        }
    }
}
