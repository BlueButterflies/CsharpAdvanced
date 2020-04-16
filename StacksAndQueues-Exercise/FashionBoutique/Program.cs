using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacityRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int numberRack = 1;
            int sum = 0;

            foreach (var clothes in sequance)
            {
                stack.Push(clothes);
            }

            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if(sum <= capacityRack)
                {
                    stack.Pop();
                }
                else
                {
                    numberRack++;
                    sum = 0;
                }
            }
            Console.WriteLine(numberRack);
        }
    }
}
