using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuest = new HashSet<string>();
            HashSet<string> regolarGuest = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuest.Add(input);
                }
                else
                {
                    regolarGuest.Add(input);
                }

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuest.Remove(input);
                }
                else
                {
                    regolarGuest.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{vipGuest.Count + regolarGuest.Count}");

            foreach (var item in vipGuest)
            {
                Console.WriteLine($"{item}");
            }

            foreach (var item in regolarGuest)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
