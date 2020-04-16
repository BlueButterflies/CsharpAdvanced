using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Stack<int> bottles = new Stack<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int wastedWater = 0;

            
            int cup = cups.Peek();

            while (cups.Count > 0 && bottles.Count > 0)
            {
                
                int bottle = bottles.Pop();
                
                if (bottle >= cup)
                {
                    bottle -= cup;
                    wastedWater += bottle;

                    cup = cups.Dequeue();

                    if(cups.Count > 0)
                    {
                        cup = cups.Peek();
                    }
                }
                else if(bottle < cup)
                {
                    cup -= bottle;


                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
