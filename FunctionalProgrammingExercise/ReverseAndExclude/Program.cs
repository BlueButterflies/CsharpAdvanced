using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int num = int.Parse(Console.ReadLine());

            Func<int, bool> result = n => n % num != 0;

            Console.Write(string.Join(" ", number.Where(result).Reverse()));
        }
    }
}
