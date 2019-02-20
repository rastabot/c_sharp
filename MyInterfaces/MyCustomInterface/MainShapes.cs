using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomInterface
{
    public abstract class MainShapes
    {
        // abstract method
        public abstract void DrawShape();

        // classic properties
        protected string shapeName;
        public string ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }
        // constructors - ctor
        public MainShapes()
        {
            this.shapeName = "Initial shape name";
        }
        public MainShapes(string str)
        {
            this.shapeName = str;
        }

    }
}
