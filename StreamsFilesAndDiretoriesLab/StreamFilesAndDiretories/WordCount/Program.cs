using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt")
                 .ToLower()
                 .Split(' ');

            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllLines("Output.txt", ReturCountOfWords(words, text).Select(x => $"{x.Key} - {x.Value}"));
        }

        private static Dictionary<string, int> ReturCountOfWords(string[] words, string[] text)
        {
            Dictionary<string, int> keyCount = new Dictionary<string, int>();

            foreach (string key in words)
            {
                keyCount[key] = 0;
            }

            foreach (string word in text)
            {
                if (keyCount.ContainsKey(word))
                {
                    keyCount[word]++;
                }
            }

            return keyCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
