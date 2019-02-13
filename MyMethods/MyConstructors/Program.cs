using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConstructors
{
    class MyClass
    {
        string userName; // null
        int userPassword = 0;
        // default constructor
        public MyClass(){}

        // constructor overload
        public MyClass(string uName)
        {
            this.userName = uName;
        }
        public MyClass(int uPass)
        {
            this.userPassword = uPass;
        }

        // override ToString()
        public override string ToString()
        {
            return string.Format("{0}, {1}", userName, userPassword);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myObj = new MyClass();
            var myObj1 = new MyClass("user name");
            var myObj2 = new MyClass(1234);

            Console.WriteLine("{0}, {1}, {2}", myObj, myObj1, myObj2);

        }
    }
}
