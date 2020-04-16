using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> name = new Queue<string>();

            while (true)
            {
                var names = Console.ReadLine();
                if (names == "End")
                {
                    break;
                }

                if (names == "Paid")
                {
                    foreach (var item in name)
                    {
                        Console.WriteLine(item);
                    }
                    name.Clear();
                }
                else
                {
                    name.Enqueue(names);
                }
            }
            Console.WriteLine($"{name.Count} people remaining.");
        }
    }
}
