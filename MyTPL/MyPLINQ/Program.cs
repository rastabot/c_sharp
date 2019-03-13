using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace MyPLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumArr = Enumerable.Range(1, 2000000).ToArray();

            //Stopwatch mySw = Stopwatch.StartNew();
            Stopwatch mySw = new Stopwatch();
            mySw.Start();

            var divideByThree = (from num in myNumArr
                                where num % 3 == 0
                                orderby num descending
                                select num).ToArray();
            mySw.Stop();

            Stopwatch mySwD = new Stopwatch();
            mySwD.Start();
            // using Parallel LINQ
            var divByThree = (from num in myNumArr.AsParallel()
                             .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                             .WithDegreeOfParallelism(Environment.ProcessorCount)
                              where num % 3 == 0
                              orderby num descending
                              select num).ToArray();
            mySwD.Stop();
            Console.WriteLine("divideByThree() : {0}", divideByThree.Count());
            Console.WriteLine("Elapsed time is : {0}", mySw.Elapsed);
            Console.WriteLine("divByThree() : {0}", divByThree.Count());
            Console.WriteLine("Elapsed time is : {0}", mySwD.Elapsed);
        }
    }
}
