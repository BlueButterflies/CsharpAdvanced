using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] infoCar = Console.ReadLine().Split();

                string model = infoCar[0];
                double fuelAmount = double.Parse(infoCar[1]);
                double fuelConsumPerKm = double.Parse(infoCar[2]);

                Car car = new Car(model, fuelAmount, fuelConsumPerKm);

                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitedInput = input.Split();

                string command = splitedInput[0];
                string model = splitedInput[1];
                double distance = double.Parse(splitedInput[2]);

                Car car = cars.Where(c => c.Model == model).FirstOrDefault();

                car.CalcolletedTravelledDistance(distance);

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(string.Join(" ", car));
            }
        }
    }
}
