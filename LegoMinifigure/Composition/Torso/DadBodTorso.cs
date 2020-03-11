using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Torso
{
    class DadBodTorso
    {
        public bool IsHairy { get; set; }
        public bool ChisledAbs => false;
        public HandType HandType { get; set; }
        public bool Shirted { get; set; }

        public void ChangeTemperature(string weather)
        {
            if(weather == "cold")
            {
                Console.WriteLine("Dad bod turns down the thermostat.");
            }
            else
            {
                Console.WriteLine("Dad bod turns up the thermostat.");
            }
        }

        public void Flex()
        {
            Console.WriteLine($@"The dad bod flexes his {(IsHairy ? "Hairy" : "Smooth")} beer belly 
                                while using his {HandType} hands to point at the lawn");
        }
    }
}
