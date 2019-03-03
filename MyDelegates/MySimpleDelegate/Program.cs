using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleDelegate
{
    // define a delegate that will return int and will take 2 arguments
    // this delegate can point to ANY method with the same signature
    public delegate int MyCalc(int x, int y);
    class MyClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        // define methods that will suit the delgate signature
        // every method can be invoked async by the delegate 
        // and also the method itself can be async 
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Square(int a)
        {
            return a * a;
        }

        // method that will give delegate information
        public static void DelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Target Name: {0}", d.Target);
            }
        }
        static void Main(string[] args)
        {
            // instance of a class
            var myObj = new Program();

            // instance of delegate and pointer 
            var myCalcDel = new MyCalc(Add);
            var myCalcDel1 = new MyCalc(myObj.Sub);
            // invoke
            myCalcDel.Invoke(20, 30);
            DelegateInfo(myCalcDel);

            var myMultiObj = new Multi();
            var multiDelObj = new MultiDel(myMultiObj.MultiMethod);
            multiDelObj.Invoke(20,30);
        }
    }
}
