using System; // System.Object
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasicDataTypes
{
    class Program
    {
        #region Local Variables types
        static void LocalTypesDeclartion()
        {
            int myInt = 1000;
            string str = "my string";
            // implicity local variable 
            var myVar = 100; // go to db and get client list
            // var keyword intruduced in NET 3. 
            // Must be initialized! (no matter what type
            // Support in dynamic languages like perl, python, JS
            // var in known only in its scope
            // myVar = 100;
            System.Boolean myB = false;
            object myObj = 200;
            bool b = new bool(); // false
            int i = new int(); // 0

            Console.WriteLine("Data are: {0}, {1}, {2}", myInt, myB, str);
        }
        #endregion

        #region Object built in functionality
        static void ObjectBuiltInFunctions()
        {
            Console.WriteLine("Object built in function");
            Console.WriteLine("100.GetHashCode()", 100.GetHashCode());
            Console.WriteLine("100.Equals()", 100.Equals(20));
            Console.WriteLine("100.ToString()", 100.ToString());
            Console.WriteLine("100.GetType()", 100.GetType());
           

            var myObj = new Program();
            myObj.Equals(20);
            myObj.GetHashCode();
            myObj.GetType();
            myObj.ToString();
            myObj.MemberwiseClone(); // shallow copy of an object 
        }



        #endregion

        #region Char type
        static void CharFunctionality()
        {
            Console.WriteLine("the char is:");
            char myChar = 'a';
            Console.WriteLine("char is? " , char.IsDigit(myChar));
            Console.WriteLine("char is? ", char.IsLetter(myChar));
            // string is upon array of chars

        }

        #endregion

        #region using Parse 

        #endregion

        #region using BigInteger

        #endregion


        static void Main(string[] args)
        {
            LocalTypesDeclartion();
            ObjectBuiltInFunctions();
            CharFunctionality();
        }
    }
}
