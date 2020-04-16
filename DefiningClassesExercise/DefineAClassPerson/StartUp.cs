using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person persons = new Person();

            persons.Name = "Gosho";
            persons.Age = 18;

            Person person = new Person
            {
                Name = "Pesho",
                Age = 20
            };
        }
    }
}
