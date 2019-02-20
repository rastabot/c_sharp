using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBaseKeyword
{
    public class BaseClass
    {
        #region Using base class constructors
        // private fields
        readonly int myNum;
        // public fields
        public string id = "12345";
        public string name = "User name";

        // ctor
        public BaseClass()
        {
            Console.WriteLine("I am in BaseClass()");
        }
        public BaseClass(int i)
        {
            this.myNum = i;
            Console.WriteLine("I am in BaseClass(int i)");
        }

        #endregion

        #region Using base class members
        public int GetNum()
        {
            return myNum;
        }
        public void GetInfo()
        {
            Console.WriteLine("ID is: {0}, Name is:{1}, MyNum is: {2}", id, name, myNum);
        }

        #endregion
    }

    public class DerivedClass : BaseClass
    {
        #region Using base class constructors

        public string str = "my derived string";

        public DerivedClass() : base()
        {
            this.str = "additional string";
        }
        public DerivedClass(int y) : base(y)
        {
            this.str = "i am in second constructor";
        }

        #endregion

        #region Using base class methods

        public new void GetInfo()
        {
            base.GetInfo();
            int a;
            a = base.GetNum();
            Console.WriteLine("calling methods using base keyword");
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myBClass = new BaseClass();
            var myDClass = new DerivedClass();
            var myDClassSecondConstructor = new DerivedClass(10);

            myDClass.GetInfo();
            int b;
            b = myDClass.GetNum();

            // myDClassSecondConstructor.GetNum();
        }
    }
}
