using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            List<int> nums = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];

                if (num % 2 == 0)
                {
                    nums.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", nums.OrderBy(n => n)));
        }
    }
}
