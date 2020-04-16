using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesGuests = Console.ReadLine()
                .Split()
                .ToList();

            Commands(namesGuests);
            PrintResult(namesGuests);
        }

        private static void PrintResult(List<string> namesGuests)
        {
            Console.WriteLine(namesGuests.Any()
               ? $"{string.Join(", ", namesGuests)} are going to the party!"
               : "Nobody is going to the party!");
        }

        static void Commands(List<string> nameGuests)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Party!")
                {
                    break;
                }

                string command = input[0];
                string condition = input[1];
                string parameters = input[2];

                switch (condition)
                {
                    case "StartsWith":
                        ForeachName(command, nameGuests, x => x.StartsWith(parameters));
                        break;
                    case "EndsWith":
                        ForeachName(command, nameGuests, x => x.EndsWith(parameters));
                        break;
                    case "Length":
                        ForeachName(command, nameGuests, x => x.Length == int.Parse(parameters));
                        break;
                }
            }
        }

        private static void ForeachName(string command, List<string> nameGuests, Func<string, bool> filtred)
        {
            for (int i = nameGuests.Count - 1; i >= 0; i--)
            {
                if (filtred(nameGuests[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            nameGuests.RemoveAt(i);
                            break;
                        case "Double":
                            nameGuests.Add(nameGuests[i]);
                            break;
                    }
                }
            }
        }
    }
}

