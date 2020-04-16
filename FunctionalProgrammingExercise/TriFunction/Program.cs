using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> firstName = Console.ReadLine()
                .Split()
                .ToList();

            var result = firstName.FirstOrDefault(x => x.ToCharArray()
            .Select(s => (int)s).Sum() >= n);

            Console.WriteLine(result);
        }
    }
}
