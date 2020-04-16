using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueCompounds = new HashSet<string>();

            for (int i = 0; i < countLines; i++)
            {
                string[] compounds = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < compounds.Length; j++)
                {
                    uniqueCompounds.Add(compounds[j]);
                }
            }
            var orderCompunds = uniqueCompounds.OrderBy(x => x);
            Console.WriteLine($"{string.Join(" ", orderCompunds)}");
        }
    }
}