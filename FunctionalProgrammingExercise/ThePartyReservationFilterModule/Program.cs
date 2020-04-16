using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameGuests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var guests = new List<string>(nameGuests);
            var filteredGuests = new List<string>();


            var commands = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Print")
            {
                switch (commands[0])
                {
                    case"Add filter":
                        filteredGuests.Add(commands[1] + " " + commands[2]);
                        break;
                    case"Remove filter":
                        filteredGuests.Remove(commands[1] + " " + commands[2]);
                        break;
                }

                commands = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var filter in filteredGuests)
            {
                var infoFilters = filter.Split(" ");


                switch (infoFilters[0])
                {
                    case "Starts":
                        guests = guests.Where(p => !p.StartsWith(infoFilters[2])).ToList();
                        break;
                    case "Ends":guests = guests.Where(p => !p.EndsWith(infoFilters[2])).ToList();
                        break;
                    case "Length": 
                        guests = guests.Where(p => p.Length != int.Parse(infoFilters[1])).ToList();
                        break;
                    case "Contains":
                        guests = guests.Where(p => !p.Contains(infoFilters[1])).ToList();
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", guests));
        }
    }
}