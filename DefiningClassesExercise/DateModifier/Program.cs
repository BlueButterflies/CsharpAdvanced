using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstData = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double result = DateModifier.GetDiffInDaysBetweenTwoDates(firstData, secondDate);

            Console.WriteLine(result);
        }
    }
}
