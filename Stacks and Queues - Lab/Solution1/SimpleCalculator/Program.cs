using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var parts = expression.Split(' ');

            var stack = new Stack<string>(parts.Reverse());
            var result = 0;

            while (stack.Count > 0)
            {
                var elements = stack.Pop();

                if (elements == "+")
                {
                    var number = stack.Pop();

                    result += int.Parse(number);
                }
                else if (elements == "-")
                {
                    var number = stack.Pop();

                    result -= int.Parse(number);
                }
                else
                {
                    result = int.Parse(elements);
                }
            }
            Console.WriteLine(result);
        }
    }
}
