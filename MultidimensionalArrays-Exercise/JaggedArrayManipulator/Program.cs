using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());

            double[][] jaggetArray = new double[rows][];


            for (long row = 0; row < rows; row++)
            {
                jaggetArray[row] = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

            }
            Analyze(jaggetArray);

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandInfo = command.Split();

                long targetRow = long.Parse(commandInfo[1]);
                long targetCol = long.Parse(commandInfo[2]);
                long value = long.Parse(commandInfo[3]);

                if(!IsInside(jaggetArray, targetRow, targetCol))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (commandInfo[0] == "Add")
                {
                    jaggetArray[targetRow][targetCol] += value;
                }
                else
                {
                    jaggetArray[targetRow][targetCol] -= value;
                }

                command = Console.ReadLine();
            }
            foreach (var row in jaggetArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static bool IsInside(double[][] jaggetArray, long targetRow, long targetCol)
        {
            return targetRow >= 0 && targetRow < jaggetArray.Length &&
                targetCol >= 0 && targetCol < jaggetArray[targetRow].Length;

        }

        private static void Analyze(double[][] jaggetArray)
        {
            for (long row = 0; row < jaggetArray.Length - 1; row++)
            {
                if (jaggetArray[row].Length == jaggetArray[row + 1].Length)
                {
                    for (long col = 0; col < jaggetArray[row].Length; col++)
                    {
                        jaggetArray[row][col] *= 2;
                        jaggetArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (long col = 0; col < jaggetArray[row].Length; col++)
                    {
                        jaggetArray[row][col] /= 2;
                    }

                    for (long col = 0; col < jaggetArray[row + 1].Length; col++)
                    {
                        jaggetArray[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
