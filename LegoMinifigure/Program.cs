using System;

namespace LegoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new SpaceGuy("Space Person", "Space Janitor");
            var astronaut2 = new SpaceGuy("Space Lady", "Space Commander");

            astronaut.DoYourJob();
            astronaut2.DoYourJob();

            // can't do this
            // astronaut.Job = "Commander";

            // also can't do this
            // astronaut.SuitedUp = false;

            var casper = new Ghost("Casper", DateTime.Today)
            // this is an Object Initalizer
            {
                Friendly = true,
            };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

        }
    }
}
