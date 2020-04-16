using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[size[0], size[1]];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var nums = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = nums[j];
                }
            }

            int subMatrixRows = 2;
            int subMatrixCol = 2;

            if (matrix.GetLength(0) < subMatrixRows || matrix.GetLength(1) < subMatrixCol)
            {
                return;
            }

            int maxSum = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixCol + 1; col++)
                {
                    var sumTwoPerTwoMatrix = 9;

                    for (int subRow = 0; subRow < subMatrixRows; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCol; subCol++)
                        {
                            sumTwoPerTwoMatrix += matrix[row + subRow, col + subCol];
                        }
                    }
                    if (sumTwoPerTwoMatrix > maxSum)
                    {
                        maxSum = sumTwoPerTwoMatrix;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            for (int i = 0; i < subMatrixRows; i++)
            {
                for (int j = 0; j < subMatrixCol; j++)
                {
                    Console.Write(matrix[maxRow + i, maxCol + j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
