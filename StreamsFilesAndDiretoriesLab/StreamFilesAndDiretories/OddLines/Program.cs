using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readerText = new StreamReader("Input.txt"))
            {
                int counter = 0;
                string lines = readerText.ReadLine();

                using (var writerText =  new StreamWriter("Output.txt"))
                {
                    while (lines != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writerText.WriteLine(lines);
                        }
                        counter++;
                        lines = readerText.ReadLine();
                    }
                }
            }
        }
    }
}
