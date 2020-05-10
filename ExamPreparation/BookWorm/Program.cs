using System;
using System.Text;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            int row = 0;
            int col = 0;

            for (int i = 0; i < size; i++)
            {
                string data = Console.ReadLine();

                matrix[i] = new char[data.Length];

                for (int j = 0; j < data.Length; j++)
                {
                    matrix[i][j] = data[j];

                    if (matrix[i][j] == 'P')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                matrix[row][col] = '-';

                if (command == "up")
                {
                    row--;

                    if (row < 0)
                    {
                        row = 0;
                        input = RemoveLetters(input);
                    }
                    else
                    {
                        input = CheckLetter(input, matrix, row, col);
                    }

                }
                else if (command == "down")
                {
                    row++;

                    if (row == matrix.Length)
                    {
                        row = matrix.Length - 1;

                        input = RemoveLetters(input);
                    }
                    else
                    {
                        input = CheckLetter(input, matrix, row, col);
                    }
                }
                else if (command == "left")
                {
                    col--;

                    if (col < 0)
                    {
                        col = 0;

                        input = RemoveLetters(input);
                    }
                    else
                    {
                        input = CheckLetter(input, matrix, row, col);
                    }
                }
                else if (command == "right")
                {
                    col++;

                    if (col == matrix.Length)
                    {
                        col = matrix.Length - 1;

                        input = RemoveLetters(input);
                    }
                    else
                    {
                        input = CheckLetter(input, matrix, row, col);
                    }
                }

                matrix[row][col] = 'P';

                command = Console.ReadLine();
            }

            Console.WriteLine(input);

            Console.WriteLine(Print(matrix));
        }

        private static string RemoveLetters(string input)
        {
            input = input.Remove(input.Length - 1, 1);

            return input;
        }

        private static string CheckLetter(string input, char[][] matrix, int row, int col)
        {
            if (char.IsLetter(matrix[row][col]))
            {
                input = input + matrix[row][col];
            }

            return input;
        }

        private static string Print(char[][] matrix)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result.Append($"{matrix[i][j]}");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
