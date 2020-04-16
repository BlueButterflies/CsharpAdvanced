using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Tires[] tiresInfo = new Tires[4];
                int counter = 0;

                for (int tireIndex = 5; tireIndex < input.Length; tireIndex += 2)
                {
                    double pressure = double.Parse(input[tireIndex]);
                    int age = int.Parse(input[tireIndex + 1]);

                    Tires tires = new Tires(pressure, age);

                    tiresInfo[counter++] = tires;
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tiresInfo);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Perssure < 1) )
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model)); 
            }
            else if(command == "flamable")
            {
                cars
                .Where(x => x.Engine.Power > 250 && x.Cargo.Type == "flamable")
                .ToList()
                .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
