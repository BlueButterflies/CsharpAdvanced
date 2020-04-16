using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbolsInfo = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbols = input[i];


                if (!symbolsInfo.ContainsKey(symbols))
                {
                    symbolsInfo.Add(symbols, 0);
                }
                symbolsInfo[symbols]++;
            }
            foreach (var item in symbolsInfo)
            {
                char symbol = item.Key;
                int counter = item.Value;

                Console.WriteLine($"{symbol}: {counter} time/s");
            }
        }
    }
}
