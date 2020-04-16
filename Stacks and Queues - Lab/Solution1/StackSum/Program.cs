using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics; 

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(number);

            while (true)
            {
                var command = Console.ReadLine().ToLower().Trim();

                if (command.StartsWith("add"))
                {
                    var parts = command.Split();
                    stack.Push(int.Parse(parts[1]));
                    stack.Push(int.Parse(parts[2]));
                }
                else if (command.StartsWith("remove"))
                {
                    var parts = command.Split();
                    var numsToRemove = int.Parse(parts[1]);

                    if (stack.Count >= numsToRemove)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (command == "end")
                {
                    break;
                }
            }
            var result =  stack.Sum();
            Console.WriteLine($"Sum: {result}");
        }
    }
}
