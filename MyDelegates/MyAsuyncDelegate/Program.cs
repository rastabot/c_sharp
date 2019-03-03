using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for Thread sync
using System.Threading;

namespace MyAsuyncDelegate
{
    public delegate int MyDelegate(int x, int y);
    class Program
    {
        public static int Add(int x, int y)
        {
            // getting information about the Thread
            Console.WriteLine("The method is invoked on Thread: {0}", 
                Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            return x + y;
        }
        // Main Thread
        static void Main(string[] args)
        {
            // delegate instance
            var myDelObj = new MyDelegate(Add);
            myDelObj.Invoke(20,20);

            // Using BeginInvoke
            IAsyncResult ias = myDelObj.BeginInvoke(10, 10, null, null);
            // checking the sync status
            while (!ias.AsyncWaitHandle.WaitOne(1000, true))
            {
                Console.WriteLine("Thread is still working....");
            }

            int showData = myDelObj.EndInvoke(ias);
            Console.WriteLine("10 + 10 = {0}", showData);

        }
    }
}
