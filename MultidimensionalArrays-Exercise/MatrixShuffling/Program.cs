using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] size = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(long.Parse)
                 .ToArray();

            long rows = size[0];
            long cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (long row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (long col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();

            while (!command.StartsWith("END"))
            {
                string[] swapCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command.StartsWith("swap") && swapCommand.Length == 5)
                {
                    if (command.StartsWith("END"))
                    {
                        return;
                    }

                    long rowFirst = long.Parse(swapCommand[1]);
                    long colFirst = long.Parse(swapCommand[2]);
                    long rowSecond = long.Parse(swapCommand[3]);
                    long colSecond = long.Parse(swapCommand[4]);

                    if (IsSwapValidation(rowFirst, colFirst, rowSecond, colSecond, rows, cols))
                    {
                        string temp = matrix[rowFirst, colFirst];
                        matrix[rowFirst, colFirst] = matrix[rowSecond, colSecond];
                        matrix[rowSecond, colSecond] = temp;

                        Print(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
        }

        private static void Print(string[,] matrix)
        {
            for (long row = 0; row < matrix.GetLength(0); row++)
            {
                for (long col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsSwapValidation(long rowFirst, long colFirst, long rowSecond, long colSecond, long row, long col)
        {
            if (rowFirst >= 0 && rowFirst <= row - 1 && colFirst >= 0 && colFirst <= col - 1
               && rowSecond >= 0 && rowSecond <= row - 1 && colSecond >= 0 && colSecond <= col - 1)
            {
                return true;
            }
            return false;
        }
    }
}
