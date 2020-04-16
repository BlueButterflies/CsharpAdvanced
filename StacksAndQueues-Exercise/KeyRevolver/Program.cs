using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());
            Stack<int> sequenceBullet = new Stack<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());
            Queue<int> locks = new Queue<int>
                (Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            int counterBulletShot = 0;

            while (sequenceBullet.Count > 0 && locks.Count > 0)
            {
                int currentBullets = sequenceBullet.Pop();
                int currentLocks = locks.Peek();

                valueOfIntelligence -= priceBullet;

                if (currentBullets <= currentLocks)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (++counterBulletShot == sizeBarrel && sequenceBullet.Count > 0)
                {
                    counterBulletShot = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{sequenceBullet.Count} bullets left. Earned ${valueOfIntelligence}");
            }
        }
    }
}
