using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Predicate<string> filtredNames = x => x.Length <= n;

            var result = names.Where(x => filtredNames(x)).ToList();

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
