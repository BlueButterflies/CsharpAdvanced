using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRangeNumber = int.Parse(Console.ReadLine());

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 1; i <= endRangeNumber; i++)
            {
                bool isValid = true;

                foreach (var nums in numbers)
                {
                    Predicate<int> filtred = n => i % n != 0;

                    if (filtred(nums))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    result.Add(i);
                }
            }

            result.ForEach(x => Console.Write(x + " "));
        }
    }
}
