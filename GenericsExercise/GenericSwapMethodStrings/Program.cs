using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Box<string>> box = new List<Box<string>>();


            int n = int.Parse(Console.ReadLine());

            for (int  i = 0;  i < n;  i++)
            {
                var input = Console.ReadLine();

                box.Add(new Box<string>(input));
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
