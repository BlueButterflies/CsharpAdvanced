using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split();
            var numsCircle = int.Parse(Console.ReadLine());

            var kids = new Queue<string>(children);

            while (kids.Count != 1)
            {
                for (int i = 1; i < numsCircle; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
