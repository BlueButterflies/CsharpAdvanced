using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> info = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continents = input[0];
                string country = input[1];
                string city = input[2];

                if (!info.ContainsKey(continents))
                {
                    info.Add(continents, new Dictionary<string, List<string>>());
                }
                if (!info[continents].ContainsKey(country))
                {
                    info[continents][country] = new List<string>();
                }

                info[continents][country].Add(city);
            }
            foreach (var infos in info)
            {
                string continent = infos.Key;

                Console.WriteLine($"{continent}:");

                foreach (var item in infos.Value)
                {
                    Console.Write($"{item.Key} -> ");
                    Console.WriteLine(string.Join(", ",item.Value));
                }
            }
        }
    }
}
