using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] infoPerson = command.Split();

                string name = infoPerson[0];
                int age = int.Parse(infoPerson[1]);
                string town = infoPerson[2];

                Person person = new Person(name, age, town);

                people.Add(person);

                command = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person personTarget = people[n - 1];
            int matches = 0;

            foreach (var personItem in people)
            {
                if (personItem.CompareTo(personTarget) == 0 && !personItem.Equals(personTarget))
                {
                    matches++;
                }
            }

            if (matches == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} { people.Count}");
            }
        }
    }
}
