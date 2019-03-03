using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTripleUsage
{
    class Program
    {
        #region Traditional delegate
        public static void TraditionalDelegate()
        {
            // creating a List<T>
            List<int> myList = new List<int>();
            myList.AddRange(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 });

            // myList.FindAll()
            Predicate<int> myCriteria = new Predicate<int>(myIsEven);

            List<int> evenNum = myList.FindAll(myCriteria);

            foreach (int num in evenNum)
            {
                Console.WriteLine("{0}\t", num);
            }
        }
        public static bool myIsEven(int i)
        {
            return (i % 2) == 0;
        }
        #endregion

        #region Anonymous delegate
        public static void AnonymousDelegate()
        {
            // creating a List<T>
            List<int> myList = new List<int>();
            myList.AddRange(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 });

            // Anonymous method
            List<int> evenNum =
                myList.FindAll(delegate(int i) 
                {
                    return (i % 2) == 0;
                });

            foreach (int num in evenNum)
            {
                Console.WriteLine("{0}\t", num);
            }
        }
        #endregion




        #region Lambda Expression
        public static void LambdaExpression()
        {
            // creating a List<T>
            List<int> myList = new List<int>();
            myList.AddRange(new int[] { 2, 3, 4, 5, 6, 7, 8, 9 });

            // Anonymous method
            List<int> evenNum =
                myList.FindAll((i) =>
                {
                    return (i % 2) == 0;
                });

            foreach (int num in evenNum)
            {
                Console.WriteLine("{0}\t", num);
            }
        }



        #endregion
        static void Main(string[] args)
        {
            TraditionalDelegate();
            AnonymousDelegate();
            LambdaExpression();
        }
    }
}
