using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Torso
{
    class AstronautTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }


        public override void Flex()
        {
            if (ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick Abs.");
            }
            else if (HandType == HandType.Xbuster)
            {
                Console.WriteLine("Welcome to the Gunshow. Pew pew!");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok.");
            }

        }

        public override void Breathe()
        {
            Console.WriteLine("Exhale... Inhale...");
        }
    }
}
