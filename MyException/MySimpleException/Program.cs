using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleException
{
    class MyClass
    {
        public static void TryString(string myStr)
        {
            if (myStr == null)
            {
                throw new ArgumentNullException("This is string erxception", 
                    "This is my message");
            }
        }
    }

    public class MyDivideClass
    {
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double x = 100, y = 0;
            double test = 0;
            //try
            //{
            test = MyDivideClass.Divide(x, y);
            //    Console.WriteLine("{0} divide by {1} = {2}", x, y, test);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("{0}", e.Message);
            //}

            string myNewStr = "my new string";
            try
            {
                string myStr = null;
                MyClass.TryString(myStr);
            }
            // Less specific
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            // global
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("{0}", myNewStr);
            }
        }
    }
}
