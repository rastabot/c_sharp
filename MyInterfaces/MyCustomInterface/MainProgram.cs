using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomInterface
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            MainShapes[] shapesArr = 
            // Boxing all objects into type MainShape
            {
                new Circle(),
                new Rectangle(),
                new Circle("Circle"),
                new Rectangle("Rectangle")
            };

            foreach (MainShapes shape in shapesArr)
            {
                shape.DrawShape();
            }


            var myCircleObj = new Circle();
            myCircleObj.Draw();

        }
    }
}
