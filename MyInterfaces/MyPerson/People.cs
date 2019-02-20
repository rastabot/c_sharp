using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerson
{
    public abstract class People
    {
        public int Age { get; set; }
        public abstract void PrintData();

        public People()
        {}

        public People(int age)
        {
            this.Age = age;
        }


    }
}
