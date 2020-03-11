using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Head
{
    class DragonHead
    {
        public int NumberOfTeeth { get; set; }
        public bool Spiked { get; set; }
        public LegoColor Color { get; set; }
        public BreathType BreathType { get; set; }

        public void Talk()
        {
            Console.WriteLine("Get outta my treasure cave!");
        }

        public void Breathe()
        {
            Console.WriteLine($"Dragon Head attacks with {BreathType}");
        }
    }

    enum BreathType
    {
        Stanky,
        Fire,
        Poison,
        Ice,
        Acid
    }
}
