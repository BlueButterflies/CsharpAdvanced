using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var triangle = new long[n][];

            for (long i = 0; i < n; i++)
            {
                triangle[i] = new long[i + 1];
            }

            for (long i = 0; i < n; i++)
            {
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;

                for (long j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] =
                    triangle[i][triangle[i].Length - j - 1] =
                       triangle[i - 1][j]  +
                       triangle[i - 1][j - 1];

                }
            }
            foreach (var item in triangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }

            /*
             * This is other print for triangle's Pascal
            foreach (var array in triangle)
            {
                foreach (var num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}
