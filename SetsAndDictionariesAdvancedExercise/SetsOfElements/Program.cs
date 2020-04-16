using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < input[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
        
            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}
