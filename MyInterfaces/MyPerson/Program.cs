using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerson
{
    class Program     {
        static void Main(string[] args)
        {
            People[] peopleArr = {
                new DifferentPeople(),
                new DifferentPeople(25)
            };

            foreach (People p in peopleArr)
            {
                p.PrintData();
            }

            var myObj = new DifferentPeople();
            myObj.CalcXY(10, 20);

        }

    }
}
