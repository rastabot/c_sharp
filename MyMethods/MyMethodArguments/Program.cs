using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMethodArguments
{
    class Point
    {
        public short x;
        public short y;
    }

    class PointManipulation
    {
        // declare member variables
        public Point start;
        public Point end;
        // Method that will return Point type 
        public Point GetThePoint()
        {
            var myPt = new Point();
            Console.Write("Enter x coordinates");
            myPt.x = short.Parse(Console.ReadLine());
            Console.Write("Enter y coordinates");
            myPt.y = short.Parse(Console.ReadLine());
            return myPt;
        }
        // method that return double
        public double DistanceFromOrigin(Point ptd)
        {
            double sqr1 = Math.Pow(ptd.x, 2);
            double sqr2 = Math.Pow(ptd.y, 2);
            double distance = Math.Sqrt(sqr1 + sqr2);
            return distance;

        }
    }

    class Program
    {
        // static keyword will create only one copy of itself 
        public static PointManipulation TestPoints()
        {
            var myPManipulation = new PointManipulation();
            Console.WriteLine("Start point...");
            myPManipulation.start = myPManipulation.GetThePoint();
            Console.WriteLine("End point...");
            myPManipulation.end = myPManipulation.GetThePoint();

            return myPManipulation;
        }

        public static void Show(PointManipulation p)
        {
            Console.WriteLine("Coords data: ");
            Console.WriteLine("Start point: P {0}, {1}", p.start.x, p.start.y);
            Console.WriteLine("End point: P {0}, {1}", p.end.x, p.end.y);
            Console.WriteLine("Distance between 2 points x: {0}", p.DistanceFromOrigin(p.start));
           
        }

        static void Main(string[] args)
        {
            PointManipulation testObj = TestPoints();
            Console.WriteLine();
            Show(testObj);
        }
    }
}
