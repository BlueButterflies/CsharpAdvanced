using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                Func<int, int> operation;

                switch (commands)
                {
                    case "add":
                        operation = x => x + 1;
                        break;
                    case "subtract":
                        operation = x => x - 1;
                        break;
                    case "multiply":
                        operation = x => x * 2;
                        break;
                    default:
                        operation = x => x;
                        break;
                }
                numbers = numbers.Select(operation).ToList();

                switch (commands)
                {
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }

                commands = Console.ReadLine();
            }
        }
    }
}
