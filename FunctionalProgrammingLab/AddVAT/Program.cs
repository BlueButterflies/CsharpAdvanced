using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            List<double> priceResult = new List<double>();
            double result = 0;

            foreach (var price in prices)
            {
                result = price + (price * 0.20);
                priceResult.Add(result);
            }

            foreach (var item in priceResult)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
