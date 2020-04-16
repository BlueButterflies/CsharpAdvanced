using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindows = int.Parse(Console.ReadLine());

            var carsStack = new Queue<string>();
            var counter = 0;

            while (true)
            {
                string car = Console.ReadLine();

                int greenSeconds = greenLight;
                int passedSecond = freeWindows;

                if (car == "END")
                {
                    Console.WriteLine($"Everyone is safe." + Environment.NewLine +
                       $"{counter} total cars passed the crossroads.");
                    return;
                }
                else if (car == "green")
                {
                    while (greenSeconds > 0 & carsStack.Count != 0)
                    {
                        var firstCar = carsStack.Dequeue();
                        greenSeconds -= firstCar.Count();

                        if (greenSeconds >= 0)
                        {
                            counter++;
                        }
                        else
                        {
                            passedSecond += greenSeconds;

                            if(passedSecond < 0)
                            {
                                Console.WriteLine($"A crash happened!" + Environment.NewLine +
                                    $"{firstCar} was hit at" +
                                    $" {firstCar[firstCar.Length + passedSecond]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }
                else 
                {
                    carsStack.Enqueue(car);
                }
            }
        }
    }
}
