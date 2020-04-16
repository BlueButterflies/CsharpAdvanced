using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];

            int stephenRow = 0;
            int stephanCol = 0;

            for (int row = 0; row < size; row++)
            {
                field[row] = new char[size];

                char[] simbolsPass = Console.ReadLine().ToCharArray();

                for (int cols = 0; cols < size; cols++)
                {
                    if (simbolsPass[cols] == 'S')
                    {
                        stephenRow = row;
                        stephanCol = cols;
                    }

                    field[row][cols] = simbolsPass[cols];
                }
            }
            
            int stars = 0;

            while (true)
            {
                field[stephenRow][stephanCol] = '-';

                string commands = Console.ReadLine();

                switch (commands)
                {
                    case "right":
                        stephanCol++;
                        break;
                    case "left":
                        stephanCol--;
                        break;
                    case "up":
                        stephenRow--;
                        break;
                    case "down":
                        stephenRow++;
                        break;
                }

                if (IsOutSide(size, stephenRow, stephanCol))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }

                char element = field[stephenRow][stephanCol];

                if (element == 'O')
                {
                    field[stephenRow][stephanCol] = '-';
                    bool isFound = false;

                    for (int row = 0; row < size; row++)
                    {
                        for (int col = 0; col < size; col++)
                        {
                            char currentElement = field[row][col];

                            if (currentElement == 'O')
                            {
                                stephenRow = row;
                                stephanCol = col;

                                isFound = true;
                                break;
                            }
                        }

                        if (isFound)
                        {
                            break;
                        }
                    }
                }
                else if (char.IsDigit(element))
                {
                    stars += element - '0';
                }

                field[stephenRow][stephanCol] = 'S';

                if (stars >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }

            Console.WriteLine($"Star power collected: {stars}");

            foreach (var col in field)
            {
                Console.WriteLine(string.Join("", col));
            }
        }

        private static bool IsOutSide(int size, int row, int col)
        {
            return row >= size ||
                   row < 0 ||
                   col >= size ||
                   col < 0;
        }
    }
}
