using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomInterface
{
    // Best practice to add public keyword to interface declaration
    public interface IDraw
    {
        // methods, properties, events 
        void Draw();
        byte Points { get; }
    }
}
