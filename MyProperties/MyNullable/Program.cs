using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNullable
{
    class Program
    {
        static int? GetNullableValue()
        {
            return null;
        }
        static string GetStringValue()
        {
            return null;
        }
        
        static void Main(string[] args)
        {
            int? x = null; // x is nullable
            // y = x, unless x is null in which case y = -1
            int y = x ?? -5;

        }
    }
}
