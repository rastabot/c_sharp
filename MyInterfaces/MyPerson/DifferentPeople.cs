using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerson
{
    public class DifferentPeople : People, IPerson
    {
        public DifferentPeople()
        {}
        public DifferentPeople(int age) : base(age)
        {}
        public int CalcXY(int x, int y)
        {
            return x * y;
        }

        public void DisplayPersonData()
        {
            Console.WriteLine("Display Person Data");
        }

        public override void PrintData()
        {
            Console.WriteLine("Display Print Data");
        }
    }
}
