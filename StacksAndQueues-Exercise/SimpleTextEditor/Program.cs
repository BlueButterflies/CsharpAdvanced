using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<string>();
            var text = "";

            for (int  i = 0;  i < n;  i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        var argument = command[1];
                        text += argument;
                        stack.Push(text);
                        break;
                    case "2":
                        var indexForErase = int.Parse(command[1]);

                        text = text.Substring(0, text.Length - indexForErase);

                        stack.Push(text);
                        break;
                    case "3":
                        var index = int.Parse(command[1]);

                        Console.WriteLine(text[index -1]);
                        break;
                    case "4":
                        stack.Pop();

                        if (stack.Count > 0)
                        {
                            text = stack.Peek();
                        }
                        else
                        {
                            text = "";
                        }
                        break;
                }
            }
        }
    }
}
