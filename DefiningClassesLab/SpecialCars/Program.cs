using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace SpecialCars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tireSets = new List<Tire[]>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "No more tires")
                {
                    break;
                }

                string[] tokens = command.Split();

                int yearOne = int.Parse(tokens[0]);
                int yearTwo = int.Parse(tokens[2]);
                int yearThree = int.Parse(tokens[4]);
                int yearFour = int.Parse(tokens[6]);
                double pressureOne = double.Parse(tokens[1]);
                double pressureTwo = double.Parse(tokens[3]);
                double pressureThree = double.Parse(tokens[5]);
                double pressure4 = double.Parse(tokens[7]);

                var tires = new Tire[4]
                {
                    new Tire(yearOne,pressureOne),
                    new Tire(yearTwo,pressureTwo),
                    new Tire (yearThree,pressureThree),
                    new Tire(yearFour,pressure4),
                };

                tireSets.Add(tires);
            }

            List<Engine> engines = new List<Engine>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Engines done")
                {
                    break;
                }

                string[] tokens = command.Split();

                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();



            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Show special")
                {
                    break;
                }

                string[] tokens = command.Split();

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                int horsePower = engines[engineIndex].HorsePower;

                double pressureSum = 0;

                var neededSet = tireSets[tiresIndex];

                foreach (var tire in neededSet)
                {
                    pressureSum += tire.Pressure;
                }

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tireSets[tiresIndex]);
                car.Engine.HorsePower = horsePower;

                if (pressureSum >= 9 && pressureSum <= 10 && car.Year >= 2017 && horsePower > 330)
                {
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}
