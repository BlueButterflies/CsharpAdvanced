using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> revisionShop =
                new SortedDictionary<string, Dictionary<string, double>>();

            string[] infoShops = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            while (infoShops[0] != "Revision")
            {
                string shop = infoShops[0];
                string product = infoShops[1];
                double price = double.Parse(infoShops[2]);

                if (!revisionShop.ContainsKey(shop))
                {
                    revisionShop.Add(shop, new Dictionary<string, double>());

                    if (!revisionShop[shop].ContainsKey(product))
                    {
                        revisionShop[shop].Add(product, price);
                    }
                }
                else
                {
                    revisionShop[shop].Add(product, price);
                }
                infoShops = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in revisionShop)
            {
                var shop = item.Key;

                Console.WriteLine($"{shop}->");

                foreach (var info in item.Value)
                {
                    Console.WriteLine($"Product: {info.Key}, Price: {info.Value}");
                }
            }
        }
    }
}
