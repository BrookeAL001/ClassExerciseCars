using System;
using System.Collections.Generic;

namespace ClassExerciseCars
{
    class Program
    {
        static void Main(string[] args)
        {
            var Truck = new Car();
            Truck.Make = "Toyota";
            Truck.Model = "Tundra";
            Truck.Year = 2020;

            var cars = new List<Car>();
            cars.Add(Truck);

            foreach (var Car in cars)
            {
                Console.WriteLine($"{Car.Make} {Car.Model} {Car.Year}");
            }
        }

    }
}
