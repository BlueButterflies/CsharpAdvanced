using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split(", ");

                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                var person = new Person(name, age);
                people.Add(person);
            }
            string condition = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());

            Func<Person, bool> filtredByAge;

            switch (condition)
            {
                case "older":
                    filtredByAge = age => age.Age >= ages;
                    break;
                default:
                    filtredByAge = age => age.Age < ages;
                    break;
            }

            string format = Console.ReadLine();

            foreach (var persons in people.Where(filtredByAge))
            {
                var result = format
                    .Replace("age", persons.Age.ToString())
                    .Replace("name", persons.Name);

                Console.WriteLine(result);
            }

            /*Other metod for filtred and print result with use Func<>
             * 
            Func<Person, string> printByFormat = null;

            switch (format)
            {
                case "name age":
                    printByFormat = print => $"{print.Name} - {print.Age}";
                    break;
                case "name":
                    printByFormat = print => $"{print.Name}";
                    break;
                case "age":
                    printByFormat = print => $"{ print.Age}";
                    break;
            }

            foreach (var item in people.Where(filtredByAge).Select(printByFormat))
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}