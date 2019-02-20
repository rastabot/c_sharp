using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClashName
{
    public class Rectangle : IDrawToFile, IDrawToForm, IDrawToPrinter
    {
        // CLR is creating the reference as private 
        // The ref implementation is private
        void IDrawToFile.Draw()
        {
            Console.WriteLine("IDrawToFile");
        }

        void IDrawToForm.Draw()
        {
            Console.WriteLine("IDrawToForm");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("IDrawToPrinter");
        }
    }
}
