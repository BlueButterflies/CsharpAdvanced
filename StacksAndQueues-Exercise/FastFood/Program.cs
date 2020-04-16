using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            // This exercise arrives 80 ponts in judge system of Softuni.

            int quantityFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orderQueue = new Queue<int>();

            int maxOrders = int.MinValue;

            for (int i = 0; i < orders.Length; i++)
            {
                orderQueue.Enqueue(orders[i]);

                if (orders[i] <= quantityFood)
                {
                    quantityFood -= orders[i];
                    orderQueue.Dequeue();
                }

                if (orders[i] > maxOrders)
                {
                    maxOrders = orders[i];
                }
            }

            Console.WriteLine(maxOrders);

            if (orderQueue.Sum() <= quantityFood)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: " + string.Join(" ", orderQueue));
            }
        }
    }
}
