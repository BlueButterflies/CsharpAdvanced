using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();

            var queues = new Queue<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var ch = numbers[i];

                if (int.Parse(ch) % 2 == 0)
                {
                    queues.Enqueue(ch);
                }
            }
            Console.WriteLine(string.Join(", ", queues));

             
        }
    }
}
