using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum
{
    // System.Enum 
    enum EmplyeeType : byte
    {
        Employee = 5,
        TeamLeader = 10,
        Manager = 15,
        CEO
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Enums");

            EmplyeeType emp = EmplyeeType.CEO;
            EmplyeeType emp1 = EmplyeeType.Manager;

            EmployeeTypeMethod(EmplyeeType.CEO);
            EmployeeTypeMethod(emp1);
        }

        static void EmployeeTypeMethod(EmplyeeType e)
        {
            switch (e)
            {
                case EmplyeeType.Employee:
                    Console.WriteLine("EmplyeeType.Employee");
                    break;
                case EmplyeeType.TeamLeader:
                    Console.WriteLine("EmplyeeType.TeamLeader");
                    break;
                case EmplyeeType.CEO:
                    Console.WriteLine("EmplyeeType.CEO");
                    break;
                default:
                    Console.WriteLine("Enter correct value");
                    break;
            }
        }
    }
}
