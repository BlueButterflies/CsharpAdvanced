using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader text = new StreamReader(@"../../../Input.txt");
            StreamWriter outputText = new StreamWriter(@"../../../Output.txt");
            int lineCounter = 0;
            char[] symbols = new[] { '-', ',', '.', '!', '?' };

            using (text)
            using(outputText)
            {
                while (!text.EndOfStream)
                {
                    string lines = text.ReadLine();

                    if (lineCounter % 2 == 0)
                    {
                        string[] words = lines.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            string currentWord = words[i];

                            foreach (var symbol in symbols)
                            {
                                currentWord = currentWord.Replace(symbol, '@');
                            }

                            words[i] = currentWord;
                        }

                        string result = string.Join(" ", words.Reverse());

                        outputText.WriteLine(result);
                    }

                    lineCounter++;
                }
            }
        }
    }
}
