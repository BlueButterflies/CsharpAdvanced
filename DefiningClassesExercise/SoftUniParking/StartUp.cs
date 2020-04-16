using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Parking parking = new Parking(2);

            Car car = new Car("Skoda", "Fabia", 65, "CC1856BG");

            Console.WriteLine(parking.AddCar(car));

            Console.WriteLine(parking.GetCar(car.RegistrationNumber));
        }
    }
}
