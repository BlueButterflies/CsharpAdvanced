using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] inputInfo = input.Split(":",StringSplitOptions.RemoveEmptyEntries);

                string contest = inputInfo[0];
                string password = inputInfo[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
                
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] inputInfo = input.Split("=>",StringSplitOptions.RemoveEmptyEntries);

                string contestName = inputInfo[0];
                string contestPassword = inputInfo[1];
                string userStudents = inputInfo[2];
                int points = int.Parse(inputInfo[3]);

                if (!contests.ContainsKey(contestName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (contests[contestName] != contestPassword) 
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!students.ContainsKey(userStudents))
                {
                    students.Add(userStudents, new Dictionary<string, int>());
                }

                if (!students[userStudents].ContainsKey(contestName))
                {
                    students[userStudents].Add(contestName, points);
                }

                if (students[userStudents][contestName] < points)
                {
                    students[userStudents][contestName] = points;
                }

                input = Console.ReadLine();
            }

            var studentTop = students
                .OrderByDescending(p => p.Value.Sum(s => s.Value))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {studentTop.Key} with total {studentTop.Value.Sum(x => x.Value)} points.");

            Console.WriteLine("Ranking:");

            foreach (var info in students.OrderBy(x => x.Key))
            {
                var user = info.Key;
                var allContests = info.Value;

                Console.WriteLine(user);

                foreach (var infoContest in allContests.OrderByDescending(x => x.Value))
                {
                    var contestName = infoContest.Key;
                    var points = infoContest.Value;

                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}
