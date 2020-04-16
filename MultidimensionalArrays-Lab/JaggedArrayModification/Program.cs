using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var jaggedArr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var num = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jaggedArr[i] = num;
            }

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var parts = command.Split(" ");
                var row = int.Parse(parts[1]);
                var col = int.Parse(parts[2]);
                var value = int.Parse(parts[3]);

                if (row < 0 || row >= jaggedArr.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (col < 0 || col >= jaggedArr[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if(command.StartsWith("Add"))
                {
                    jaggedArr[row][col] += value;
                }
                else if(command.StartsWith("Subtract"))
                {
                    jaggedArr[row][col] -= value;
                }
            }
            /*
             * This is other metod for print jaggedArr
            foreach (var item in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", item));
            } */
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
