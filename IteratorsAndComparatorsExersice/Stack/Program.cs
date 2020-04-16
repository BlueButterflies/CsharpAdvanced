using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stacks = new Stack<int>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] elements = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var token = elements[0];

                if (token == "Push")
                {
                    stacks.Push(elements.Skip(1).Select(int.Parse).ToArray());
                }
                else if (token == "Pop")
                {
                    Console.WriteLine(stacks.Pop());
                }
                command = Console.ReadLine();
            }

            foreach (var item in stacks.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }

            foreach (var item in stacks.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
