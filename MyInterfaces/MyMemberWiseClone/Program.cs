using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMemberWiseClone
{
    public class MyClassInfo
    {
        public int myId;
        public MyClassInfo(int _myId)
        {
            this.myId = _myId;
        }
    }

    public class Person
    {
        public int age;
        public string name;
        public MyClassInfo myIdInfo;
        
        // shallow copy
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        // deep copy
        public Person DeepCopy()
        {
            Person myCopy = (Person)this.MemberwiseClone();
            myCopy.myIdInfo = new MyClassInfo(this.myIdInfo.myId);
            return myCopy;
        }

        /// <summary>
        /// Overriding object methods 
        /// </summary>
        public int MyNum { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Double))
                return false;
            else
                return MyNum == (Double)obj;
        }
        public override int GetHashCode()
        {
            return MyNum;
        }
        public override string ToString()
        {
            return MyNum.ToString();
        }

    }
    class Program
    {
        public static void DisplayValues( Person p)
        {
            Console.WriteLine("Name: {0}, Age:{1}", p.name, p.age);
            Console.WriteLine("Id value is: {0}", p.myIdInfo.myId);
        }
        static void Main(string[] args)
        {
            // create instances 
            var personObj1 = new Person();
            personObj1.age = 30;
            personObj1.name = "Test user";
            personObj1.myIdInfo = new MyClassInfo(12345);

            // using shallowcopy
            Person personObj2 = personObj1.ShallowCopy();
            // myPObj = pObj
            Console.WriteLine("Original values");
            DisplayValues(personObj1);
            Console.WriteLine("Copied values");
            DisplayValues(personObj2);

            personObj2.age = 35;
            personObj2.name = "New user name";
            personObj2.myIdInfo.myId = 789;
            Console.WriteLine("Copied values");
            DisplayValues(personObj2);
            // deep copy
            Person personObj3 = personObj1.DeepCopy();

            Console.WriteLine(personObj2.Equals(personObj1));
            Console.WriteLine(personObj2.Equals(personObj1));
            Console.WriteLine(personObj1.Equals(personObj1));
            Console.WriteLine(personObj2 == personObj1);
            Console.WriteLine(personObj2 == personObj1);

        }
    }
}
