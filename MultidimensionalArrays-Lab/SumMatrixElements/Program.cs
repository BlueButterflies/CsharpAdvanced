using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[rowCol[0], rowCol[1]];

            //int sumElements = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] nums = Console.ReadLine()
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)

                    matrix[i, j] = nums[j];
            }

            //Or this metod
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        sumElements += matrix[i, j];
            //    }
            //}

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
           //or this - Console.WriteLine(sumElements);
            Console.WriteLine(matrix.Cast<int>().Sum());
        }
    }
}
