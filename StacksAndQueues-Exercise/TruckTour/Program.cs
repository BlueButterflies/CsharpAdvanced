using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            int truckFuel = 0;
            int startPump = 0;

            for (int i = 0; i < value; i++)
            {
                int[] pumpInfo = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();


                int quantityPetrol = pumpInfo[0];
                int distance = pumpInfo[1];

                truckFuel += quantityPetrol - distance;

                if (truckFuel < 0)
                {
                    truckFuel = 0;
                    startPump = i + 1;
                }
            }
            Console.WriteLine(startPump);
        }
    }
}
