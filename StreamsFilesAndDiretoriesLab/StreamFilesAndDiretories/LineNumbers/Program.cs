using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readerText = new StreamReader("Input.txt"))
            {
                int counter = 1;
                string lines = readerText.ReadLine();

                using (var writeText = new StreamWriter("Output.txt"))
                {
                    while (lines != null)
                    {
                        writeText.WriteLine($"{counter}. {lines}");
                        lines = readerText.ReadLine();
                        counter++;
                    }

                }
            }
        }
    }
}
