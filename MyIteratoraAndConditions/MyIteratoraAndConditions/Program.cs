using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIteratorsAndConditions
{
    class Program
    {
        #region if-else
        static void UsingIfElse()
        {
            string strData = "some text";
            if (strData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            else
            {
                Console.WriteLine("string is less or equal to zero ");
            }
            Console.WriteLine();
        }

        #endregion

        #region switch
        static void UsingSwitch()
        {
            Console.WriteLine("1 [c#], 2 [vb]");
            Console.Write("please choose programming language: ");
            string progLang = Console.ReadLine();
            int userInput = int.Parse(progLang);

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("C# chosen");
                    break;
                case 2:
                    Console.WriteLine("VB chosen");
                    break;
                default:
                    Console.WriteLine("non of the above... try again");
                    break;
            }
            Console.WriteLine();

            //switch (userInput)
            //{
            //    case "c#":
            //        Console.WriteLine("C# chosen");
            //        break;
            //    case "vb":
            //        Console.WriteLine("VB chosen");
            //        break;
            //    default:
            //        Console.WriteLine("non of the above... try again");
            //        break;
            //}
        }


        #endregion

        #region while-do
        static void UsingWhile()
        {
            string userDone = "";
            while (userDone.ToLower() != "yes")
            {
                Console.Write("are u sure? [yes],[no]");
                userDone = Console.ReadLine();
                Console.WriteLine("i am in while loop...");
            }
         }

        static void UsingDoWhile()
        {
            string userDone = "";
            do
            {
                Console.Write("are u sure? [yes],[no]");
                userDone = Console.ReadLine();
                Console.WriteLine("i am in while loop...");

            } while (userDone.ToLower() != "yes");
            
        }



        #endregion

        #region for and foreach
        static void UsingForloop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
        }
        static void UsingForeachLoop()
        {
            string[] myCars = { "Audi","BMW","Citroen"};

            foreach (string c in myCars)
            {
                Console.WriteLine(c);
            }

            int[] myNum = { 10, 20, 30 };
            foreach (int n in myNum)
            {
                Console.WriteLine(n);
            }

        }

        #endregion

        static void Main(string[] args)
        {
            UsingIfElse();
            UsingSwitch();
            UsingWhile();
            UsingDoWhile();
            UsingForloop();
            UsingForeachLoop();
        }
    }
}
