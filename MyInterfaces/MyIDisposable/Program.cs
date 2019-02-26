using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace MyIDisposable
{
    public class Employee : IDisposable
    {
        bool IsDisposed = false;
        string name;
        public Employee(string _name)
        {
            this.name = _name;
        }
        public void PaySalary(bool isDisp)
        {
            if (!IsDisposed)
            {
                Console.WriteLine("Employee {0} paid", name);
            }
            else
            {
                throw new ObjectDisposedException("Employee object already disposed!");
            }
        }
        public void Dispose()
        {
            //GC.Collect();
            PaySalary(true);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // the USING keyword is dispose pattern in c#
            // within the block of the using we can write any logic that we want
            // the using keyword and the barckets are recommending the GC (garbage collector)
            // to start working
            using (SqlConnection myCon = new SqlConnection())
            {
                // here come the logic of the operation 
            }
            using (SqlConnection myCon = new SqlConnection("conStr"))
            {

            }
            var myEmp = new Employee("Test Employee");
            using (myEmp)
            {
                myEmp.PaySalary(true);
                // myEmp.Dispose();
            }
        }
    }
}
