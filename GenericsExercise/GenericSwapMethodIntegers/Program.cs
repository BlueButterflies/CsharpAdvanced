using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Box<int>> box = new List<Box<int>>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Add(new Box<int>(input));
            }

            int[] index = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Swap(box, index[0], index[1]);

            foreach (var boxes in box)
            {
                Console.WriteLine(boxes);
            }
        }

        static void Swap<T>(IList<Box<T>> list, int indexOne, int indexTwo)
        {
            Box<T> temp = list[indexOne];
            list[indexOne] = list[indexTwo];
            list[indexTwo] = temp;
        }
    }
}
