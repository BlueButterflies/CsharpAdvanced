using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vLogger = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] inputInfo = command.Split();

                if (inputInfo[1] == "joined")
                {
                    string user = inputInfo[0];

                    if (!vLogger.ContainsKey(user))
                    {
                        vLogger.Add(user, new Dictionary<string, HashSet<string>>());
                        vLogger[user].Add("followed", new HashSet<string>());
                        vLogger[user].Add("followers", new HashSet<string>());
                    }

                }
                else if (inputInfo[1] == "followed")
                {
                    string mainUser = inputInfo[2];
                    string follower = inputInfo[0];

                    if (!vLogger.ContainsKey(mainUser) || !vLogger.ContainsKey(follower))
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (mainUser == follower)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    vLogger[mainUser]["followers"].Add(follower);
                    vLogger[follower]["followed"].Add(mainUser);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");

            var sortedVLogger = vLogger
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["followed"].Count)
                .ToDictionary(k => k.Key, v => v.Value);

            int counter = 1;

            foreach (var sorted in sortedVLogger)
            {
                var vlogger = sorted.Key;
                var collectionOfPeople = sorted.Value;

                Console.WriteLine($"{counter}. {vlogger} : {collectionOfPeople["followers"].Count} followers, {collectionOfPeople["followed"].Count} following");

                if(counter == 1)
                {
                    foreach (var username in collectionOfPeople["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {username}");
                    }
                }
                counter++;
            }
        }
    }
}
