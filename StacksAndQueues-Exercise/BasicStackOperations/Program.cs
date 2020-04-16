using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int numsOfPush = firstLine[0];
            int numsOfPop = firstLine[1];
            int numsEual = firstLine[2];

            Stack<int> numsStak = new Stack<int>();

            for (int i = 0; i < Math.Min(numsOfPush, secondLine.Length); i++)
            {
                numsStak.Push(secondLine[i]);
            }

            for (int i = 0; i < numsOfPop; i++)
            {
                if (numsStak.Count == 0)
                {
                    break;
                }
                numsStak.Pop();
            }

            if (numsStak.Contains(numsEual))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNum = int.MaxValue;

                foreach (int num in numsStak)
                {
                    if(num < minNum)
                    {
                        minNum = num;

                        Console.WriteLine(minNum);
                    }
                }
            }

            if(numsStak.Count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
