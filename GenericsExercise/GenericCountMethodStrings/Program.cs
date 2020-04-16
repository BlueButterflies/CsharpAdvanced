using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Box<string>> box = new List<Box<string>>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                box.Add(new Box<string>(input));
            }

            string value = Console.ReadLine();

            Console.WriteLine(GreaterCount(box, value));
        }

        public static int GreaterCount<T>(IEnumerable<Box<T>> value, T item)
               where T: IComparable<T>
        {
            int count = 0;

            foreach (var box in value)
            {
                if (box.CompareTo(item) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
