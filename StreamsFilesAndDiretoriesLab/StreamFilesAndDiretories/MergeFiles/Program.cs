using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = File.ReadAllLines("InputOne.txt");
            string[] secondInput = File.ReadAllLines("InputTwo.txt");

            List<string> output = new List<string>();

            for (int i = 0; i < firstInput.Length; i++)
            {
                output.Add(firstInput[i]);
                output.Add(secondInput[i]);
            }
            File.WriteAllLines("Output.txt", output);
        }
    }
}


