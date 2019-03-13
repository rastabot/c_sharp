using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinqOverObjects
{
    public class Car
    {
        public int Speed{ get; set; }
        public string Color{ get; set; }
        public string Make { get; set; }
        public string CarName { get; set; }


        public override string ToString()
        {
            return string.Format("Speed:{0}, Color:{1}, Make:{2}, CarName:{3}",
                Speed, Color, Make, CarName);
        }
    }
}
