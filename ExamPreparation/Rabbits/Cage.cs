using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Rabbit rabbit)
        {
            if (this.rabbits.Count < this.Capacity)
            {
                this.rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            try
            {
                var result = rabbits.FirstOrDefault(x => x.Name == name);

                this.rabbits.Remove(result);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void RemoveSpecies(string species) => this.rabbits.RemoveAll(x => x.Species == species);

        public Rabbit SellRabbit(string name)
        {
            var result = this.rabbits.Where(x => x.Name == name).FirstOrDefault();

            if (result != null)
            {
                result.Available = false;
            }

            return result;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] result = rabbits.Where(x => x.Species == species).ToArray();

            foreach (var rabbit in result)
            {
                rabbit.Available = false;
            }

            foreach (var rabbit in rabbits)
            {
                if (rabbit.Species == species)
                {
                    rabbit.Available = false;
                }
            }

            return result;
        }

        public int Count => this.rabbits.Count;

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in rabbits.Where(r => r.Available))
            {
                result.AppendLine($"{rabbit}");
            }

            return result.ToString().Trim();
        }
    }
}
