using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GlassVelue = 25;
            const int AluminiumValue = 50;
            const int LithiumValue = 75;
            const int CarbonFiberValue = 100;

            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> items = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Dictionary<string, int> crafedItems = new Dictionary<string, int>
            {
                {"Aluminium",0},
                {"Carbon fiber",0},
                {"Glass",0},
                {"Lithium",0}
            };

            while (liquids.Count > 0 && items.Count > 0)
            {
                int liquidsCurrent = liquids.Dequeue();
                int itemsCurrent = items.Pop();

                int sum = liquidsCurrent + itemsCurrent;

                switch (sum)
                {
                    case GlassVelue:
                        crafedItems["Glass"] += 1;
                        break;
                    case AluminiumValue:
                        crafedItems["Aluminium"] += 1;
                        break;
                    case LithiumValue:
                        crafedItems["Lithium"] += 1;
                        break;
                    case CarbonFiberValue:
                        crafedItems["Carbon fiber"] += 1;
                        break;
                    default:
                        items.Push(itemsCurrent + 3);
                        break;
                }
            }

            if (!crafedItems.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine($"Physical items left: { string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var item in crafedItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
