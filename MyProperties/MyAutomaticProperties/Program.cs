using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutomaticProperties
{
    public class MyCalendar
    {
        /// <summary>
        /// Using automatic properties - since NET 3 (2008)
        /// 1. Private backing hidden fields are automatically generated
        /// 2. no need to define private 
        /// 3. we can use just get{}
        /// 4. we can use other access modifier such as protected 
        /// 5. we can't apply any condition to set
        /// </summary>
        /// <param name="args"></param>
        /// 
        public int Day { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        
        // prop + 2 * tab = automatic properties
        // propfull + 2 * tab = classic properties 

    }
    class Program
    {        
        static void Main(string[] args)
        {
            // Up to version 2008 - NET 2
            MyCalendar myObjCal = new MyCalendar();
            myObjCal.Day = 2;
            myObjCal.Week = 4;

            // object initialization from NET 3 and up 
            var myObj = new MyCalendar
            {
                Day = 5,
                Week = 23,
                Month = 6
            };
            Console.WriteLine("{0}",myObj.Week );
        }
    }
}
