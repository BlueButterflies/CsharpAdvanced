using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var diagonal = new int[size][];

            for (int i = 0; i < size; i++)
            {
                var nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                diagonal[i] = nums;
            }

            var sumLeft = 0;
            var sumRight = 0;

            for (var i = 0; i < size; i++)
            {
                var j = size - i - 1;

                sumLeft += diagonal[i][i];
                sumRight += diagonal[i][j];
            }

            var diff = Math.Abs(sumLeft - sumRight);

            Console.WriteLine(diff);
        }
    }
}
