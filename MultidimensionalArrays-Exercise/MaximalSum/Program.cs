﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            InizializeMatrix(matrix);

            int max = int.MinValue;
            int targetRow = 0;
            int targetCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (currentSum > max)
                    {
                        max = currentSum;
                        targetRow = row;
                        targetCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");

            for (int row = targetRow; row <= targetRow + 2; row++)
            {
                for (int col = targetCol; col <= targetCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        static void InizializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                 int[] symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }
        }
    }
}
