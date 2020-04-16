using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();

            List<int> evenOrOdd = new List<int>();

            for (int i = nums[0]; i <= nums[1]; i++)
            {
                evenOrOdd.Add(i);
            }

            switch (condition)
            {
                case "odd":
                    Console.Write(string.Join(" ", evenOrOdd.Where(n => n % 2 != 0)));
                    break;
                case "even":
                    Console.Write(string.Join(" ", evenOrOdd.Where(n => n % 2 == 0)));
                    break;
            }
        }
    }
}
