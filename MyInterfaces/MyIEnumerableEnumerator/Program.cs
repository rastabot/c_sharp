using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for non generic collections 
using System.Collections; // IEnumerable + IEnumerator = foreach()

namespace MyIEnumerableEnumerator
{
    public class Person
    {
        public string firstName, lastName;
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
    }

    public class People : IEnumerable
    {
        // creating a member varuable of type array
        public Person[] myPersonList;

        public People(Person[] peopleArr)
        {
            for (int i = 0; i < peopleArr.Length; i++)
            {
                myPersonList[i] = peopleArr[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new PeopleIEnumerator(myPersonList);
        }
    }

    public class PeopleIEnumerator : IEnumerator
    {
        // Enumerators are positioned by default before the first element
        // in the list until MoveNext() is invoked

        // creating collection 
        public Person[] myPersonListEnum;
        // Enumerator position set to -1
        int position = -1;
        public PeopleIEnumerator(Person[] list)
        {
            this.myPersonListEnum = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < this.myPersonListEnum.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get
            {
                try
                {
                    return this.myPersonListEnum[position];
                }
                catch (Exception)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] personArr = new Person[3];
            personArr[0] = new Person("Avi","Ron");
            personArr[1] = new Person("Asi", "Mon");
            personArr[2] = new Person("Tiki", "Poor");

            // IEnumerable + IEnumerator - default lazy loading
            // we can use pattern to get eager loading
            foreach (Person p in personArr)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }
        }
    }
}
