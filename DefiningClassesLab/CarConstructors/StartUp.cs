using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsum = double.Parse(Console.ReadLine());

            Car firstInfo = new Car();
            Car secondInfo = new Car(make, model, year);
            Car thirdInfo = new Car(make, model, year, fuelQuantity, fuelConsum);


            Console.WriteLine(firstInfo.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(secondInfo.WhoAmI());
            Console.WriteLine();
            Console.WriteLine(thirdInfo.WhoAmI());
        }
    }
}
