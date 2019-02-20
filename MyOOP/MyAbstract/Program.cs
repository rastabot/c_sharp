using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbstract
{
    public abstract class Shape
    {
        protected int X, Y;
        // abstract member
        public abstract void Draw(int x = 10, int y = 20);
        // regular method
        public int GetXY(int x, int y)
        {
            this.X = x;
            this.Y = y;

            return this.X * this.Y;
        }
    }
    //public abstract class DerivedClass : Shape
    //{
    //    public abstract void Move();
    //}

    class Rectangle : Shape
    {
        // public abstract void Move();
        public override void Draw(int x = 30, int y = 50)
        {
            Console.WriteLine("Print ");
        }
        public void Print()
        {
            Console.WriteLine("Test");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape myObj = new Rectangle();
            myObj.Draw();
            myObj.Draw(19);

            var testObj = new Rectangle();
            testObj.Print();


        }
    }
}
