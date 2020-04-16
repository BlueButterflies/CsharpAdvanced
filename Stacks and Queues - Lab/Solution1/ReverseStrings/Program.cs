using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> symbols = new Stack<char>(input);

            while (symbols.Count > 0)
            {
                char ch = symbols.Pop();
                Console.Write(ch);
            }

        }
    }
}
