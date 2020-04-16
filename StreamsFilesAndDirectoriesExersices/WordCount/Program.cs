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
            Dictionary<string, int> listWords = new Dictionary<string, int>();

            using (StreamReader words = new StreamReader(@"../../../Resource/Words.txt"))
            using (StreamReader text = new StreamReader(@"../../../Resource/Text.txt"))
            using (StreamWriter actual = new StreamWriter(@"../../../Output/ActualResult.txt"))
            {
                while (!words.EndOfStream)
                {
                    string[] word = words.ReadLine().Split();


                    foreach (var itemWord in word)
                    {
                        if (!listWords.ContainsKey(itemWord.ToLower()))
                        {
                            listWords.Add(itemWord.ToLower(), 0);
                        }
                    }
                }

                while (!text.EndOfStream)
                {
                    string[] texts = text.ReadLine().Split(new char[] { ' ', ',', '?', ';', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var itemText in texts)
                    {
                        if (listWords.ContainsKey(itemText.ToLower()))
                        {
                            listWords[itemText.ToLower()]++;
                        }
                    }
                }

                foreach (var item in listWords.OrderByDescending(x => x.Value))
                {
                    actual.WriteLine(item.Key + " - " + item.Value);
                }

            }
            using (StreamReader output = new StreamReader(@"../../../Output/ActualResult.txt"))
            using (StreamReader expected = new StreamReader(@"../../../Resource/ExpectedResult.txt"))
            {
                var firstFileLine = output.ReadLine();
                var secondFileLine = expected.ReadLine();

                while (output.EndOfStream && expected.EndOfStream)
                {
                    break;
                }

                if (firstFileLine != secondFileLine)
                {
                    Console.WriteLine("Files aren't the same.");
                }
                Console.WriteLine("Files are the same.");
            }

        }
    }
}
