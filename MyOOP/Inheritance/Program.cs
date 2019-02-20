using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        private short age;
        //private short Age;
        public short Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
            }

        }
        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }
    }

    class Cat : Animal
    {
        // Hide field member x
        new public static int x = 2000;
        public new void Move(string str = "new move")
        {
            Console.WriteLine("Cat is moving");
        }
    }

    class Dog : Animal
    {
        public new void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }

    class Fish 
    {
        public void Move()
        {
            Console.WriteLine("Fish is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myCat = new Cat();
            var myDog = new Dog();
            var myFish = new Fish();

            myCat.Age = 2;
            myDog.Age = 3;
            myFish.Move();

            myCat.Move();
            myDog.Move();

        }
    }
}
    

