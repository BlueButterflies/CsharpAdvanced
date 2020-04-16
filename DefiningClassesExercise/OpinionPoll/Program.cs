using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace OpinionPoll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();

                string name = info[0];
                int age = int.Parse(info[1]);


                if (age > 30)
                {
                    Person person = new Person(name, age);

                    people.Add(person);
                }

            }

            foreach ( var members in people.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{members.Name} - {members.Age}");
            }

        }
    }
}
