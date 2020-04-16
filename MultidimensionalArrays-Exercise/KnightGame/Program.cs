using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] knights = new char[size, size];

            for (int row = 0; row < knights.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < knights.GetLength(1); col++)
                {
                    knights[row, col] = input[col];
                }
            }
            
            int killerRow = 0;
            int killerCol = 0;
            int knightsCount = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < knights.GetLength(0); row++)
                {
                    for (int col = 0; col < knights.GetLength(1); col++)
                    {
                        int currentKnightsAttacks = 0;

                        if (knights[row, col] == 'K')
                        {
                            if (IsInside(knights, row - 2, col + 1) && knights[row - 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row - 2, col - 1) && knights[row - 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row - 1, col + 2) && knights[row - 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row - 1, col - 2) && knights[row - 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row + 1, col + 2) && knights[row + 1, col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row + 1, col - 2) && knights[row + 1, col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row + 2, col + 1) && knights[row + 2, col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            if (IsInside(knights, row + 2, col - 1) && knights[row + 2, col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                        }

                        if (currentKnightsAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    knights[killerRow, killerCol] = '0';

                    knightsCount++;
                }
                else
                {
                    Console.WriteLine(knightsCount);
                    break;
                }
            }
        }

        private static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &
                col >= 0 && col < matrix.GetLength(1);
        }
    }
}
