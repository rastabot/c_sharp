using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnonymousMethod
{
    public delegate void MyMessage(string str);
    class Program
    {
        static void Main(string[] args)
        {
            MyMessage myObj = delegate(string myImp) 
            {
                Console.WriteLine(myImp);
            };

            myObj.Invoke("Test data");
        }
        // classic delegate
        public void MyStr(string msg)
        {
            Console.WriteLine("Test calsssic delegate");
        }
    }
}
