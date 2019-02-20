using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomInterface
{
    public class Circle : MainShapes, IDraw
    {
        public Circle()
        {}
        public Circle(string name) : base(name)
        {}

        // interface implementation 
        public byte Points
        {
            get { return 0; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing circle");
        }

        // abstract member override
        public override void DrawShape()
        {
            Console.WriteLine("Drawing {0} the shape", shapeName);
        }

    }

    public class Rectangle : MainShapes, IDraw
    {
        public Rectangle()
        {}

        public Rectangle(string name) : base(name)
        {}
        public byte Points
        {
            get { return 0; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }

        public override void DrawShape()
        {
            Console.WriteLine("Drawing {0} the shape", shapeName);
        }
    }
}
