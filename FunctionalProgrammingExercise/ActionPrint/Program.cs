using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Stack<string>(Console.ReadLine().Split().Reverse());

            void PrintAction(string x) => Console.WriteLine(x);

            while (name.Any())
            {
                PrintAction(name.Pop());
            }
        }
    }
}
