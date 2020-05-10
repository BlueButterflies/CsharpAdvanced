using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private readonly List<Hero> Heroes;

        public HeroRepository()
        {
            this.Heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            this.Heroes.Add(hero);
        }

        public void Remove(string name)
        {
            this.Heroes.Where(x => x.Name != name).Select(y => y).ToList();
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.Heroes
                    .OrderByDescending(x => x.Item.Strength)
                    .First();
        }

        public Hero GetHeroWithHighestAbility()
        {

            return this.Heroes
                    .OrderByDescending(x => x.Item.Ability)
                    .First();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.Heroes
                    .OrderByDescending(x => x.Item.Intelligence)
                    .First();
        }

        public int Count => this.Heroes.Count;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in this.Heroes)
            {
                sb.AppendLine($"{hero}");
            }

            return sb.ToString();
        }
    }
}
