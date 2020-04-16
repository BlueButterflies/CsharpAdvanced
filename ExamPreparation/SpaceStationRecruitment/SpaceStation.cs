using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;

            this.astronauts = new List<Astronaut>();
        }


        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Astronaut astronaut)
        {
            if (this.astronauts.Count < this.Capacity)
            {
                this.astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name) => this.astronauts.Remove(this.astronauts.FirstOrDefault(x => x.Name == name));

        public Astronaut GetOldestAstronaut()
             => this.astronauts.OrderByDescending(x => x.Age).First();


        public Astronaut GetAstronaut(string name)
            => this.astronauts.FirstOrDefault(x => x.Name == name);

        public int Count => this.astronauts.Count; //Or this variant - public int Count {get{retur this.astronauts.Count}};

        public string Report()
        {
            return $"Astronauts working at Space Station {this.Name}:" +
                   Environment.NewLine +
                   string.Join(Environment.NewLine, this.astronauts.Select(x => x.ToString()));
        }
    }
}
