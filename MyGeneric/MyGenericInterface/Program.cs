using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericInterface
{
    public interface ICalc<T>
    {
        T Add(T arg1 , T arg2);
        T Sub(T arg1, T arg2);
        T Multi(T arg1, T arg2);
        T Divide(T arg1, T arg2);
        void Test();
        void Display(string str);

    }
    class Program : ICalc<int>
    {

        static void Main(string[] args)
        {
            var myObj = new Program();
            myObj.Add(10, 30);
        }

        public int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        public int Divide(int arg1, int arg2)
        {
            return arg1 / arg2;
        }

        public int Multi(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        public int Sub(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public void Test()
        {
            Console.WriteLine("Test()");
        }
        public void Display(string str)
        {
            Console.WriteLine("Display()");
        }
    }
}
