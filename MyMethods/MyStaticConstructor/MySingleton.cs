using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStaticConstructor
{
    public class MySingleton
    {
        // Property to expose 
        private static MySingleton instance = null;
        private static readonly object myLock = new object();
        public static MySingleton Instance
        {
            get {
                if (instance == null)
                {
                    lock (myLock)
                    {
                        instance = new MySingleton();
                    }
                }
                return instance;
            }
    
        }
    }
}
