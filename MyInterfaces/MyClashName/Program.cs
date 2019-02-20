using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClashName
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRectObj = new Rectangle();

            // interface implementation is privatewe can not point on the type
            // so we must do casting to the necessary type
            // in c# 7 (VS 2017) the casting operation is redundent 
            IDrawToFile myVar = (IDrawToFile)myRectObj;
            myVar.Draw();

            // second option - casting 
            ((IDrawToForm)myRectObj).Draw();
            ((IDrawToFile)myRectObj).Draw();
            ((IDrawToPrinter)myRectObj).Draw();


        }
    }
}
