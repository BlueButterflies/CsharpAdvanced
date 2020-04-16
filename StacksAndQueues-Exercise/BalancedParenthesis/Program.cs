using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequenceParentheses = Console.ReadLine();

            var openParentheses = new Stack<char>();


            if(sequenceParentheses.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < sequenceParentheses.Length; i++)
            {
                char parentheses = sequenceParentheses[i];

                if(parentheses == '(' || parentheses == '[' || parentheses == '{')
                {
                    openParentheses.Push(parentheses);
                }
                else if(openParentheses.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    char lastParentheses = openParentheses.Pop();

                    if(lastParentheses == '(' && parentheses != ')' || lastParentheses == '[' && parentheses != ']' || lastParentheses == '{' && parentheses != '}')
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                }
            }
            if (openParentheses.Count == 0)
            {
                Console.WriteLine("YES");
                return;
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
