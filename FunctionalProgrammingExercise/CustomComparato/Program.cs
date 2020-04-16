using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace CustomComparato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers
                .OrderBy(x => x % 2 != 0)
                .ThenBy(x => x)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}
