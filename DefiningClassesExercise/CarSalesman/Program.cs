using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engine = new List<Engine>();
            List<Car> car = new List<Car>();

            int countEngine = int.Parse(Console.ReadLine());

            for (int i = 0; i < countEngine; i++)
            {
                string[] infoEngine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = infoEngine[0];
                int power = int.Parse(infoEngine[1]);

                Engine engine1 = new Engine(model, power);

                if (infoEngine.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(infoEngine[2], out displacement))
                    {
                        engine1.Displacement = displacement;
                    }
                    else
                    {
                        engine1.Efficiency = infoEngine[2];
                    }
                }
                else if (infoEngine.Length == 4)
                {
                    int displacement = int.Parse(infoEngine[2]);
                    string efficiency = infoEngine[3];
                    engine1.Displacement = displacement;
                    engine1.Efficiency = efficiency;
                }
                engine.Add(engine1);
            }

            int counterCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < counterCar; i++)
            {
                string[] infoCar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = infoCar[0];
                string engineCar = infoCar[1];

                Engine engines1 = engine.FirstOrDefault(e => e.Model == engineCar);

                Car cars = new Car(model, engines1);

                if (infoCar.Length == 3)
                {
                    int weight;
                    if (int.TryParse(infoCar[2], out weight))
                    {
                        cars.Weight = weight;
                    }
                    else
                    {
                        cars.Color = infoCar[2];
                    }
                }
                else if (infoCar.Length == 4)
                {
                    int weight = int.Parse(infoCar[2]);
                    string color = infoCar[3];
                    cars.Weight = weight;
                    cars.Color = color;
                }

                car.Add(cars);
            }

            foreach (var item in car)
            {
                Console.WriteLine(item);
            }
        }
    }
}
