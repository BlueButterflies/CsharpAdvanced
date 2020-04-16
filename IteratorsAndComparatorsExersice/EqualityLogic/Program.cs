using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedSet<Person> peopleSet = new SortedSet<Person>();
            HashSet<Person> peopleHash = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);

                peopleHash.Add(person);
                peopleSet.Add(person);
            }

            Console.WriteLine(peopleHash.Count);
            Console.WriteLine(peopleSet.Count);
        }
    }
}
