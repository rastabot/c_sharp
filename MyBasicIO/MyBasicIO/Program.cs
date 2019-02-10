// directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace 
namespace MyBasicIO
{
    /// <summary>
    /// This calss is 
    /// </summary>
    // 1 or more classes 
    class Program
    {
        /// <summary>
        /// Members of a class:
        /// 1. variables
        /// 2. Properties - get set
        /// 3. Methods include constructors
        /// </summary>

        // c# is type safe and case sensetive 
        // 2 types:
        // 1. Primitve types
        // 2. Advance types 

        bool myBool; // false
        string str; // null
        int myInt; // 0
        Int32 myIntTest; // 0
        double myDouble; // 0.0
        object myObj; // null 
        float myFloat = 2.2F;
                
        #region GetUserData method
        // (optional)access_modifier (optional)static (must)return type (must)Method name
        private static void GetUserData(){
            Console.Write("Please enter user name:");
            string userName = Console.ReadLine();
            Console.Write("Please enter password:");
            string userPass = Console.ReadLine();
        }

        #endregion

        static void Main(string[] args)
        {
            Program.GetUserData();
            //Console.ReadLine();
        }
    }
}
