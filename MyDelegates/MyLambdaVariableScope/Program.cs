using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLambdaVariableScope
{
    // delegates
    delegate bool DelWithoutArgs();
    delegate bool DelWithArgs(int i);
    class Program
    {
        // creating member variables
        DelWithoutArgs myDelNoArgs;
        DelWithArgs myDelArgs;

        public void Test()
        {

        }
        // create method that will use Lambda expression
        public void TestDelegates(int userInput)
        {
            int j = 2;
            // using Lambda expression - myDelNoArgs
            myDelNoArgs = () =>
            {
                j = 10;
                return j > userInput;
            };
            // using Lambda expression - myDelArgs
            myDelArgs = (x) =>
            {
                return x == j;
            };
            bool myInvoke = myDelNoArgs.Invoke();
        }
        static void Main(string[] args)
        {
            var myObj = new Program();
            myObj.TestDelegates(10);

        }
    }
}
