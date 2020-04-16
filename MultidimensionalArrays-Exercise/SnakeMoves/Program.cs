using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snakeName = Console.ReadLine();

            int rows = size[0];
            int cols = size[1];

            char[,] snakeMovie = new char[rows, cols];

            int counter = 0;
            for (int row = 0; row < snakeMovie.GetLength(0); row++)
            {

                if (row % 2 == 0)
                {

                    for (int col = 0; col < snakeMovie.GetLength(1); col++)
                    {
                        snakeMovie[row, col] = snakeName[counter++];

                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = snakeMovie.GetLength(1) - 1; col >= 0; col--)
                    {
                        snakeMovie[row, col] = snakeName[counter++];

                        if (counter == snakeName.Length)
                        {
                            counter = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < snakeMovie.GetLength(0); row++)
            {
                for (int col = 0; col < snakeMovie.GetLength(1); col++)
                {
                    Console.Write(snakeMovie[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
