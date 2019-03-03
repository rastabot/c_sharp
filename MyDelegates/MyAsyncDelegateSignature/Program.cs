using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For classic thread
using System.Threading;
// for using remoting message in runtime
using System.Runtime.Remoting.Messaging;

namespace MyAsyncDelegateSignature
{
    public delegate int MyDelegate(int x, int y);
    class Program
    {
        public static int Add(int x, int y)
        {
            // getting information about the Thread
            Console.WriteLine("The method is invoked on Thread: {0}",
                Thread.CurrentThread.ManagedThreadId);
            return x + y;
        }

        // Creating a method that will suit AsyncCallback 
        public static void MyMethodTarget(IAsyncResult iasr)
        {
            // creating member variable of type AsyncResult and cast it into IAsyncResult
            // this is for information purposes
            AsyncResult ar = (AsyncResult)iasr;

        }
        static void Main(string[] args)
        {
            // delegate instance
            var myDelObj = new MyDelegate(Add);
            myDelObj.Invoke(20, 20);

            // Using BeginInvoke
           IAsyncResult ias = myDelObj.BeginInvoke(10, 10, 
                new AsyncCallback(MyMethodTarget), "Using async result");

            // Because we are using AsyncCallback that utilizing 
            // System.Runtime.Remoting.Messaging the Thread safe part is done 
            // automatically by the CLR
            //while (!ias.AsyncWaitHandle.WaitOne(1000, true))
            //{
            //    Console.WriteLine("Thread is still working....");
            //}

            int showData = myDelObj.EndInvoke(ias);
            Console.WriteLine("10 + 10 = {0}", showData);
        }
    }
}
