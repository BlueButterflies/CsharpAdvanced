using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> infoStudents = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!infoStudents.ContainsKey(name))
                {
                    infoStudents[name] = new List<double>();
                }
                infoStudents[name].Add(grade);
            }
            foreach (var item in infoStudents)
            {
                var name = item.Key;
                var grade = item.Value;

                Console.Write($"{name} -> ");

                foreach (var grades in grade)
                {
                    Console.Write($"{grades:f2} ");
                }
                Console.WriteLine($"(avg: {grade.Average():f2})");

            }
        }
    }
}
