
using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigure.Composition.Head;
using LegoMinifigure.Composition.Legs;
using LegoMinifigure.Composition.Torso;

namespace LegoMinifigure
{
    enum Location
    {
        Earth = 3,
        Space,
        SpaceStation
    }

    class Astronaut
    {
        private string v1;
        private string v2;
        private ZoeHead head;
        private AstronautTorso torso;
        private AstronautLegs legs;

        // Public Property
        public Location Location { get; set; }
        // Expression Bodied Property {always readonly}
        public bool SuitedUp => Name != "Space Person";
        // Read-Only Property
        public string Name { get; }
        // Public Property with a private setter
        public string Job { get; private set; }
        public int OxygenLevel { get; set; }

        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public ZoeHead Head { get; set; }

        public Astronaut(string name, string job, ZoeHead head, AstronautTorso torso, AstronautLegs legs)
        {
            Name = name;
            Job = job;

            Head = head;
            Torso = torso;
            Legs = legs;
        }

        //public SpaceGuy(string v1, string v2, ZoeHead head, AstronautTorso torso, AstronautLegs legs)
        //{
        //    this.v1 = v1;
        //    this.v2 = v2;
        //    this.head = head;
        //    this.torso = torso;
        //    this.legs = legs;
        //}

        public void DoYourJob(int stepsToWalk)
        {
            Console.WriteLine($"Here I am. Doing all my {Job} duties... definitely being a very effective {Job}.");
            Legs.Walk(stepsToWalk);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(stepsToWalk);
        }

        //public void Promote()
        //{
        //    Job = "Commander of Janitors";
        //}
    }
}
