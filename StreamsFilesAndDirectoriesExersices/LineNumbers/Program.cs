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
            int counter = 1;

            using (var readerText = new StreamReader(@"../../../TextInput.txt"))
            {
                using (var writeText = new StreamWriter(@"../../../TextOutput.txt"))
                {
                    while (!readerText.EndOfStream)
                    {
                        var lines = readerText.ReadLine();

                        int symbols = 0;
                        int space = 0;

                        foreach (var item in lines)
                        {
                            if (item == ' ')
                            {
                                space++;
                            }
                            else if (!char.IsLetter(item))
                            {
                                symbols++;
                            }

                        }

                        var letterSymbols = lines.Length - symbols - space;

                        writeText.WriteLine($"Line {counter}: {lines}({letterSymbols})({symbols})");

                        counter++;
                    }

                }
            }
        }
    }
}
