using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDefaultKeyword
{
    public struct MyStruct<T>
    {
        public T myX { get; set; }
        public T myY { get; set; }
        public MyStruct(T xPos, T yPos)
        {
            this.myX = xPos;
            this.myY = yPos;
        }
        // this method will use default keyword to reset 
        // back to the default values of the generic fields
        public void ResetValues()
        {
            myX = default(T);
            myY = default(T);
        }
        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}", myX, myY);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myStruct = new MyStruct<int>(10,10);
            Console.WriteLine("{0}", myStruct);

            var myStructString = new MyStruct<string>("Test1","Test2");
            Console.WriteLine("{0}", myStructString);

            //myStruct.myX = 0;
            //myStruct.myY = 0;
            //myStructString.myX = null;
            Console.WriteLine("X = {0}, Y = {1}", myStruct.myX, myStruct.myY);
            myStruct.ResetValues();
            Console.WriteLine("X = {0}, Y = {1}", myStruct.myX, myStruct.myY);

        }
    }
}
