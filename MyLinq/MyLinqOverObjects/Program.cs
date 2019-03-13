using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinqOverObjects
{
    class Program
    {
        #region Basic LINQ Queries
        static void BasicSelection(List<Car> myCarList)
        {
            // basic linq query
            var allCars = from myLocalList
                       in myCarList
                       select myLocalList;

            foreach (var myNewList in allCars)
            {
                Console.WriteLine(myNewList.ToString());
            }

        }

        static void GetCarColor(List<Car> myCarList)
        {
            var getColor = from c
                           in myCarList
                           select c.Color;

            foreach (var item in getColor)
            {
                Console.WriteLine("Color is:{0}", item);
            }
        }

        #endregion


        #region Subsets LINQ Queries
        static void UsingMake(List<Car> myCarList)
        {
            var getToyota = from c
                            in myCarList
                            where c.Make == "Toyota" && c.Speed >= 110
                            orderby c.CarName descending
                            select c;

            foreach (Car myCar in getToyota)
            {
                Console.WriteLine(myCar.ToString());
            }
        }

        // select 2 or more fields e.g. speed and make,
        // we need to choose 2 fileds from Car collection.
        // in LINQ to do so we need to use Anonymous Type 
        // we use anonymous type in order to create new object based on the base object
        static void UsingAnonymousTypes(List<Car> myCarList)
        {
            var getTwoFields = (from c
                               in myCarList
                               select
                               new { c.Speed, c.Make }).ToList();

            foreach (var myItem in getTwoFields)
            {
                Console.WriteLine(myItem.ToString());
            }

        }



        #endregion

        static void Main(string[] args)
        {
            List<Car> myCarList = new List<Car>()
            {
                new Car { Speed = 100, Make = "Toyota",
                    Color = "Red", CarName = "MyToyota"},
                new Car { Speed = 110, Make = "Ford",
                    Color = "Green", CarName = "MyFord"},
                new Car { Speed = 120, Make = "Toyota",
                    Color = "Blue", CarName = "MyToyota120"},
                new Car { Speed = 130, Make = "Volvo",
                    Color = "Yellow", CarName = "MyVolvo"}
            };

            BasicSelection(myCarList);
            GetCarColor(myCarList);
            UsingAnonymousTypes(myCarList);
        }
    }
}
