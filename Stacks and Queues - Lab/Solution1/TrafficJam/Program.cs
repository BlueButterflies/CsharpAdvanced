using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCars = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            var count = 0;

            while (true)
            {
                var command = Console.ReadLine();

                if(command == "end")
                {
                    break;
                }

                if (command == "green")
                {
                    for (int i = 0; i < numCars; i++)
                    {
                        if (queue.Count > 0)
                        {
                            var car = queue.Dequeue();
                            count++;
                            Console.WriteLine(car + " passed!");
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
