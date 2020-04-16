using System;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];

            int firstRow = 0;
            int firstCol = 0;
            int secondRow = 0;
            int secondCol = 0;

            for (int row = 0; row < size; row++)
            {
                field[row] = new char[size];

                string symbols = Console.ReadLine();

                for (int cols = 0; cols < size; cols++)
                {
                    if (symbols[cols] == 'f')
                    {
                        firstRow = row;
                        firstCol = cols;
                    }
                    else if(symbols[cols] == 's')
                    {
                        secondRow = row;
                        secondCol = cols;
                    }

                    field[row][cols] = symbols[cols];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                string firstCommand = command[0];
                string secondCommand = command[1];

                MovePlayer(ref firstRow, ref firstCol, firstCommand, size);

                if (field[firstRow][firstCol] == 's')
                {
                    field[firstRow][firstCol] = 'x';
                    break;
                }

                field[firstRow][firstCol] = 'f';

                MovePlayer(ref secondRow, ref secondCol, secondCommand, size);

                if (field[secondRow][secondCol] == 'f')
                {
                    field[secondRow][secondCol] = 'x';
                    break;
                }

                field[secondRow][secondCol] = 's';
            }

            foreach (var col in field)
            {
                Console.WriteLine(string.Join("", col));
            }
        }

        public static void MovePlayer(ref int row, ref int col, string direction, int size)
        {
            switch (direction)
            {
                case "left":
                    if (col - 1 < 0)
                    {
                        col = size - 1;
                    }
                    else
                    {
                        col -= 1;
                    }
                    break;
                case "right":
                    if (col + 1 >= size)
                    {
                        col = 0;
                    }
                    else
                    {
                        col += 1;
                    }
                    break;
                case "up":
                    if (row - 1 < 0)
                    {
                        row = size - 1;
                    }
                    else
                    {
                        row -= 1;
                    }
                    break;
                case "down":
                    if (row + 1 >= size)
                    {
                        row = 0;
                    }
                    else
                    {
                        row += 1;
                    }
                    break;
            }
        }
    }
}
