using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPolymorphism
{
    public class Animal
    {
        private short age;
        public short Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
            }
        }
        public Animal()
        {
            Console.WriteLine("I am in animal CTOR");
        }
        // Virtual method that can act as stand alone in derived class
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise");
        }
        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }

    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("I am in dog CTOR");
        }
        // using polymorphism
        public override void MakeNoise()
        {
            Console.WriteLine("Dog is barking");
        }
        public new void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }

    class Program
    {
        public static void UsingPolymorphism(Animal a)
        {
            a.MakeNoise();
        }
        static void Main(string[] args)
        {
            // classic - creating an instance of the object itself
            var myDogObj = new Dog();
            myDogObj.Age = 3;

            myDogObj.MakeNoise();

            // second option - creating an instance of the derived class based on Animal type
            Animal myDogObjP = new Dog();
            myDogObjP.MakeNoise();


            UsingPolymorphism(myDogObjP);
        }
    }
}
