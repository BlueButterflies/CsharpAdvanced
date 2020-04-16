using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace BasicQueueOperations
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


            int numsOfQueue = firstLine[0];
            int numsOfDequeue = firstLine[1];
            int numsEqual = firstLine[2];

            Queue<int> numsQueue = new Queue<int>();

            for (int i = 0; i < Math.Min(numsOfQueue, secondLine.Length); i++)
            {
                numsQueue.Enqueue(secondLine[i]);
            }

            for (int i = 0; i < numsOfDequeue; i++)
            {
                if (numsQueue.Count == 0)
                {
                    break;
                }
                numsQueue.Dequeue();
            }

            if (numsQueue.Contains(numsEqual))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numsQueue.Count != 0)
                {
                    Console.WriteLine(numsQueue.Min());
                }
            }

            if (numsQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
