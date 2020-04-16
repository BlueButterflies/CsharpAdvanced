using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Tournament")
                {
                    break;
                }

                string[] info = command.Split();

                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealt = int.Parse(info[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                Trainer currentTrainer = trainers[trainerName];
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealt);

                currentTrainer.Pokemon.Add(pokemon);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var currentTrainer in trainers)
                {
                    if (currentTrainer.Value.Pokemon
                        .Any(p => p.Element == command))
                    {
                        currentTrainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in currentTrainer.Value.Pokemon)
                        {
                            pokemon.Health -= 10;
                        }

                        currentTrainer.Value.Pokemon.RemoveAll(p => p.Health <= 0);
                    }
                }
            }
            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
