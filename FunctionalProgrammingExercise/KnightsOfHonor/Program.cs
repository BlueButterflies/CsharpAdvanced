using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = new Queue<string>(Console.ReadLine().Split());

            void Print(string x) => Console.WriteLine("Sir " + x);

            while (peoples.Any())
            {
                Print(peoples.Dequeue());
            }
        }
    }
}
