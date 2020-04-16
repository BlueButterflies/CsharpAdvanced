using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodDoubles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Box<double>> box = new List<Box<double>>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Add(new Box<double>(input));
            }

            double value = double.Parse(Console.ReadLine());

            Console.WriteLine(GreaterCount(box, value));

        }

        static int GreaterCount<T>(IEnumerable<Box<T>> value, T item)
               where T : IComparable<T>
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
