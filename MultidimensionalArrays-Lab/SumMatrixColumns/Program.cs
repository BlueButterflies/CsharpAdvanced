using System;
using System.Linq;

namespace SumMatrixColumns
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

            var sumCol = new int[size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var num = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = num[col];
                    sumCol[col] += matrix[row, col];
                }
            }
            foreach (var num in sumCol)
            {
                Console.WriteLine(num);
            }
            // or with for 
            //for (int i = 0; i < sumCol.Length; i++)
            //{
            //    Console.WriteLine(sumCol[i]);
            //}

            //This is other metod for exercise and without variable "sumCol" up  
            //for (int col = 0; col < matrix.GetLength(1); col++)
            //{
            //    var sum = 0;

            //    for (int row = 0; row < matrix.GetLength(0); row++)
            //    {
            //        sum += matrix[row, col];
            //    }

            //    Console.WriteLine(sum);
            //}
        }
    }
}
