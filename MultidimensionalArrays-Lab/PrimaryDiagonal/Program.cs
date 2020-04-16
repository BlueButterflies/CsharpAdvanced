using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            }

            var sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i][i];
            }

            //This is other metod for exercise
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        if (row == col)
            //        {
            //            sum += matrix[row][col];
            //        }
            //    }
            //}
            Console.WriteLine(sum);
        }
    }
}
