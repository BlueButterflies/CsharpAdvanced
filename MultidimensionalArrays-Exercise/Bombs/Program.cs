using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Bombs
{
    class Program
    {
        static long[,] matrix;

        static void Main(string[] args)
        {
            long size = long.Parse(Console.ReadLine());

            matrix = new long[size, size];

            for (int row = 0; row < size; row++)
            {
                long[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] coordinationBomb = Console.ReadLine().Split();


            foreach (var coordBombs in coordinationBomb)
            {
                int[] coordinationBombs = coordBombs.Split(",")
                    .Select(int.Parse)
                    .ToArray();

                int rows = coordinationBombs[0];
                int cols = coordinationBombs[1];

                CoordinationBomb(rows, cols);
            }


            PrintCell();
            PrintMatrix();
        }

        private static void CoordinationBomb(int row, int col)
        {
            long explosion = matrix[row, col];

            if (explosion > 0)
            {
                Explosion(row - 1, col - 1, explosion);
                Explosion(row - 1, col, explosion);
                Explosion(row - 1, col + 1, explosion);
                Explosion(row, col - 1, explosion);
                Explosion(row, col + 1, explosion);
                Explosion(row + 1, col - 1, explosion);
                Explosion(row + 1, col, explosion);
                Explosion(row + 1, col + 1, explosion);

                matrix[row, col] = 0;
            }
        }

        private static void Explosion(int row, int col, long explosion)
        {
            if (row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1)
                && matrix[row, col] > 0)
            {
                matrix[row, col] -= explosion;
            }
        }

        private static void PrintCell()
        {
            int aliveCellCount = 0;
            long aliveCellSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    long aliveCell = matrix[row, col];

                    if (aliveCell > 0)
                    {
                        aliveCellCount++;
                        aliveCellSum += aliveCell;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCellCount}");
            Console.WriteLine($"Sum: {aliveCellSum}");
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
