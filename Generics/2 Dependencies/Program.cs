using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _2_Dependencies
{
    class Program
    {
        public class CarComparer : IEqualityComparer<Car>, IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return String.Compare(x.Name, y.Name);
            }

            public bool Equals(Car x, Car y)
            {
                return String.Equals(x.Name, y.Name);
            }

            public int GetHashCode(Car obj)
            {
                return obj.Name.GetHashCode();
            }
        }
        static void Main(string[] args)
        {
            var cars = new SortedDictionary<string, SortedSet<Car>>();

            cars.Add("Opel", new SortedSet<Car>(new CarComparer())
            {
                new Car { Name = "Zafira"},
                new Car { Name = "Moka"}, 
                new Car { Name = "Meriva"}, 
                new Car { Name = "Tigra"}, 
                new Car { Name = "Corsa"}, 
                new Car { Name = "Astra"},
                new Car { Name = "Astra"},
                new Car { Name = "Astra"}
            });

            cars.Add("Ford", new SortedSet<Car>(new CarComparer()));
            cars["Ford"].Add(new Car { Name = "Mondeo"});
            cars["Ford"].Add(new Car { Name = "Puma" });
            cars["Ford"].Add(new Car { Name = "Kuga" });
            cars["Ford"].Add(new Car { Name = "Fiesta" });
            cars["Ford"].Add(new Car { Name = "Ka" });
            cars["Ford"].Add(new Car { Name = "Eskort" });
            cars["Ford"].Add(new Car { Name = "Eskort" });
            cars["Ford"].Add(new Car { Name = "Eskort" });
            cars["Ford"].Add(new Car("Eskort"));
            cars["Ford"].Add(Car.Add("Eskort"));

            foreach (var brand in cars)
            {
                Console.WriteLine($"Brand: {brand.Key}");

                foreach (Car car in brand.Value)
                {
                    Console.WriteLine($"\tCar: {car.Name}");
                }

            }
            

        }
    }
}
