using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure
{
    class Ghost
    {
        public bool Friendly { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public string HauntingLocation { get; set; }
        public DateTime DeathDay { get; set; }

        public Ghost(string name, DateTime deathDay)
        {
            DeathDay = deathDay;
            Name = name;
        }

        public void Haunt(string hauntingLocation)
        {
            HauntingLocation = hauntingLocation;
            Console.WriteLine($"{Name} has moved into {hauntingLocation}");
        }

        public void Spook()
        {
            if (string.IsNullOrEmpty(HauntingLocation)) return;
            Console.WriteLine($"{Name} does a spook at {HauntingLocation}");
        }
    }
}
