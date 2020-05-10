using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int counterMaches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                var male = males.Peek();
                var femal = females.Peek();

                if (male <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (femal <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (male % 25 == 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }

                if (femal % 25 == 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }

                if (femal == male)
                {
                    counterMaches++;
                    females.Dequeue();
                    males.Pop();
                }
                else
                {
                    females.Dequeue();
                    males.Push(males.Pop() - 2);
                }
            }

            Console.WriteLine($"Matches: {counterMaches}");

            if (males.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }

            if (females.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
