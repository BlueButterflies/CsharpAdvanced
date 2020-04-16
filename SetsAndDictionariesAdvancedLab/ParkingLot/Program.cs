using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numberCars = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] infoParking = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string inOut = infoParking[0];
                string numCar = infoParking[1];

                if (inOut == "IN")
                {
                    numberCars.Add(numCar);
                }
                else
                {
                    numberCars.Remove(numCar);
                }

                input = Console.ReadLine();
            }

            if (numberCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in numberCars)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
