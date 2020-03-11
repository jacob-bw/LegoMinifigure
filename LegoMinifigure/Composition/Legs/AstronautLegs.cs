﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Legs
{
    class AstronautLegs
    {
        public bool HasPants { get; set; }
        public ShoeType Shoes { get; set; }
        Random _rng = new Random(4);


        public void Walk (int steps)
        {
            Console.WriteLine($"The Astronaut legs moonwalked {steps} steps");
        }

        public int Jump()
        {
            var heightOfJump = _rng.Next();

            return heightOfJump;
        }

    }
        enum ShoeType
        {
            Boots,
            Sneakers,
            Slippers,
        }
}
