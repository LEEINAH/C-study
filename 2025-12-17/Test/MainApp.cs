using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Test
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car() {Cost = 56, MaxSpeed = 120 },
                new Car() {Cost = 70, MaxSpeed = 150 },
                new Car() {Cost = 45, MaxSpeed = 180 },
                new Car() {Cost = 32, MaxSpeed = 200 },
                new Car() {Cost = 82, MaxSpeed = 280 }
            };

            var selected = cars
                           .Where (car => car.Cost >= 50 && car.MaxSpeed >= 150)
                           .Select (car => new
                           {
                               Cost = car.Cost,
                               MaxSpeed = car.MaxSpeed
                           });

            foreach (var car in selected) 
                Console.WriteLine($"Cost : {car.Cost}, MaxSpeed : {car.MaxSpeed}");
        }
    }
}