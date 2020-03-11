using System;
using System.Collections.Generic;
using LegoMinifigure.Composition.Legs;
using LegoMinifigure.Composition.Head;
using LegoMinifigure.Composition.Torso;


namespace LegoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead
            {
                FacialExpression = "smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.Boots,

            };

            var atorso = new AstronautTorso
            {
                ChiseledAbs = true,
                NumberOfArms = 4,
                Shirted = true,
                HandType = HandType.Xbuster

            }; 
            
            var dtorso = new AstronautTorso
            {
                ChiseledAbs = true,
                NumberOfArms = 4,
                Shirted = true,
                HandType = HandType.Xbuster
            };

            var astronaut = new Astronaut("Space Person", "Space Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Space Commander", head, dtorso, legs);

            astronaut.DoYourJob(25);
            astronaut2.DoYourJob(15);


            atorso.Breathe();
            dtorso.Breathe();

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


            var torsos = new List<TorsoBase>();
            torsos.Add(dtorso);
            torsos.Add(atorso);

            foreach (var torso in torsos)
            {
                torso.Breathe();
                torso.Flex();
            }
        }
    }
}
