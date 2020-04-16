using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string colors = input[0];

                if (!wardrobe.ContainsKey(colors))
                {
                    wardrobe.Add(colors, new Dictionary<string, int>());
                }

                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var clothesInfo in clothes)
                {
                    if (!wardrobe[colors].ContainsKey(clothesInfo))
                    {
                        wardrobe[colors].Add(clothesInfo, 0);
                    }
                    wardrobe[colors][clothesInfo]++;
                }
            }
            string[] inputTargetItem = Console.ReadLine().Split();

            string targetColor = inputTargetItem[0];
            string targetCloth = inputTargetItem[1];

            foreach (var currentColor in wardrobe)
            {
                Console.WriteLine($"{currentColor.Key} clothes:");

                foreach (var clothing in currentColor.Value)
                {
                    string resultText = string.Empty;

                    if (clothing.Key == targetCloth && targetColor == currentColor.Key)
                    {
                        resultText = " (found!)";
                    }
                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}{resultText}");
                }
            }
        }
    }
}
