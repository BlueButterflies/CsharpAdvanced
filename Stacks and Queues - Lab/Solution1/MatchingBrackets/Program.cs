using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var @char = input[i];

                if (@char == '(')
                {
                    stack.Push(i);
                }
                else if(@char == ')')
                {
                    var leftIndex = stack.Pop();

                    var expression = input.Substring(leftIndex, i - leftIndex + 1);

                    Console.WriteLine(expression);
                }
            }
        }
    }
}
