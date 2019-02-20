using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEncapsulation
{
    public class MyClassA
    {
        protected int x = 100;

        private int b = 500;
        public int y = 200;
        internal int a = 300;
    }
    public class MyClassB : MyClassA
    {
        MyClassA aTest;
        protected string str = "ClassB string";
        static void Test()
        {
           var myObj = new MyClassB();
            myObj.str = "New value";


        }
    }
    class Program : MyClassB
    {
        static void Main(string[] args)
        {
            var myClassAObj = new MyClassA();
            var myClassBObj = new MyClassB();
            //myClassBObj.
            var myProgObj = new Program();
            myProgObj.x = 1000;
        }
    }
}
