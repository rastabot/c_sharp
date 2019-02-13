using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MySingleton
{
    class LoadData
    {
        // Property
        private static LoadData _instance;
        // List of demo data 
        private ArrayList myList = new ArrayList();
        // random 
        private Random myRndObj = new Random();
        // Lock synchronized object
        private static object myLock = new object();

        // constructor (private or protected is singleton)
        protected LoadData()
        {
            myList.Add("Server 1");
            myList.Add("Server 2");
            myList.Add("Server 3");
            myList.Add("Server 4");
        }

        // method that will use the singelton pattern
        public static LoadData GetLoadedData()
        {
            if (_instance == null)
            {
                lock (myLock)
                {
                    _instance = new LoadData();
                }           
            }
            return _instance;
        }

        // simple use of random
        public string Server
        {
            get {
                int myRnd = myRndObj.Next(myList.Count);
                return myList[myRnd].ToString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var myObj = new LoadData();

            LoadData myObj1 = LoadData.GetLoadedData();
            LoadData myObj2 = LoadData.GetLoadedData();
            LoadData myObj3 = LoadData.GetLoadedData();

            if (myObj1 == myObj2 && myObj2 == myObj3)
            {
                Console.WriteLine("Same instance");
            }

            LoadData myLoadObj = LoadData.GetLoadedData();
            for (int i = 0; i < 10; i++)
            {
                string myServer = myLoadObj.Server;
                Console.WriteLine("Created servers " + myServer);

            }
            Console.ReadKey();
        }
    }
}
