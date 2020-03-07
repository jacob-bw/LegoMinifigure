
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure
{
    enum Location
    {
        Earth = 3,
        Space,
        SpaceStation
    }

    class SpaceGuy
    {
        // Public Property
        public Location Location { get; set; }
        // Expression Bodied Property {always readonly}
        public bool SuitedUp => Name != "Space Person";
        // Read-Only Property
        public string Name { get; }
        // Public Property with a private setter
        public string Job { get; private set; }
        public int OxygenLevel { get; set; }
        public int SpaceWalks { get; set; }

        public SpaceGuy(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void DoYourJob()
        {
            Console.WriteLine($"Here I am. Doing all my {Job} duties... definitely being a very effective {Job}.");
        }

        //public void Promote()
        //{
        //    Job = "Commander of Janitors";
        //}
    }
}
