using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Program
    {
        #region Simple Array
        static void ArrayInitialization()
        {
            Console.WriteLine("Araay init");
            string[] myStrArr = new string[] { "one","two","three"};
            Console.WriteLine("we have {0} elements in the array ", myStrArr.Length);
        }

        #endregion

        #region Multi Dimentional Array
        static void MultiDim()
        {
            int[,] myMatrixArr = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myMatrixArr[i, j] = i * j;
                }
            }

        }

        #endregion

        #region Array as parameter
        static void ArrAsParam(int[] myIntArr)
        {
            for (int i = 0; i < myIntArr.Length; i++)
            {
                Console.WriteLine("Index {0} is {1}", i, myIntArr[i]);
            }
        }
        #endregion

        #region ArrayList
        static void UsingArrayList()
        {
            int index;
            ArrayList myList = new ArrayList();
            myList.Add(100);
            myList.Add(true);
            myList.Add('t');

            Random myRndObj = new Random();
            for (index = 0; index < 10; index++)
            {
                myList.Add(myRndObj.Next(100) % 10);
                Console.WriteLine(myList[index]);
            }
            //foreach (StringBuilder item in myList)
            //{
            //    item.Add(myRndObj.Next(100) % 10);
            //    Console.WriteLine(myList[index].ToString());
            //}

        }

        #endregion
        static void Main(string[] args)
        {
            ArrayInitialization();
            MultiDim();

            int[] myIntArr = new int[] { 2,4,6};
            ArrAsParam(myIntArr);

            UsingArrayList();
        }
    }
}
