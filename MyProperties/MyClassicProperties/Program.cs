using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassicProperties
{
    public class MyCalendar
    {
        // fileds
        private int day;
        private int week;
        private int month;

        // classic properties since NET 1.1 up today 
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Week
        {
            get { return week; }
            set { week = value; }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if ((value > 0) && value < 13)
                {
                    month = value;
                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCalObj = new MyCalendar();
            myCalObj.Day = 3;
            myCalObj.Week = 12;
            myCalObj.Month = 14;

            Console.WriteLine("Day is {0}, Week is {1}, Month is {2}", 
                myCalObj.Day, myCalObj.Week, myCalObj.Month);
        }
    }
}
