using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConstraints
{
    public class Car
    {
        public int CarSpeed { get; set; }
        public string CarName{ get; set; }
        public Car(){}
        public Car(int speed, string name)
        {
            this.CarSpeed = speed;
            this.CarName = name;
        }
    }

    public class MiniCar : Car
    {
        public MiniCar(int mc, string mcn) : base(mc, mcn){}
    }
    public class SportCar : Car
    {
        public SportCar(int sc, string scn) : base(sc, scn) {}
    }
    public class Bus
    {
        public Bus()
        {
            Console.WriteLine("I am in bus class");
        }
    }
    // Generic class that will inherit IEnumerable<T> and the constraint will
    // be of type Car
    public class MyGenericCollection<T> : IEnumerable<T> where T : Car
    {
        List<T> myList = new List<T>();
        // Get a car
        public T GetCar(int position)
        {
            return myList[position];
        }
        // Add a car
        public void AddCar(T c)
        {
            myList.Add(c);
        }
        // Clear the list
        public void ClearList()
        {
            myList.Clear();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myList.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myObj = new MyGenericCollection<Car>();

            myObj.AddCar(new Car(100, "Test"));
            myObj.AddCar(new Car(110, "Test1"));
            myObj.AddCar(new MiniCar(120, "Test2"));
            myObj.AddCar(new SportCar(130, "Test3"));

            foreach (Car c in myObj)
            {
                Console.WriteLine("Car name is:{0} Car speed is:{1}", 
                    c.CarName, c.CarSpeed.ToString());
            }

        }
    }
}
