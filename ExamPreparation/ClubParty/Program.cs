using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();
            List<int> groups = new List<int>();

            int currentCapacity = 0;

            while (stack.Count > 0)
            {
                string currentElement = stack.Pop();

                bool isNumber = int.TryParse(currentElement, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }
                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (currentCapacity + parsedNumber > maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", groups)}");

                        groups.Clear();

                        currentCapacity = 0;
                    }

                    if (halls.Count > 0)
                    {
                        groups.Add(parsedNumber);

                        currentCapacity += parsedNumber;
                    }
                }
            }
        }
    }
}
