using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<string> elements = command.Split().Skip(1).ToList();
            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            try
            {
                while (command != "END")
                {
                    if (command == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (command == "Move")
                    {
                        bool result = listyIterator.Move();
                        Console.WriteLine(result);
                    }
                    else if (command == "HasNext")
                    {
                        bool result = listyIterator.HasNext();
                        Console.WriteLine(result);
                    }
                    else if (command == "PrintAll")
                    {
                        Console.WriteLine(string.Join(" ", listyIterator));

                    }

                    command = Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
