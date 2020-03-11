using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigure.Composition.Head
{
    class ZoeHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }

        public void Talk()
        {
            Console.WriteLine($"Zoe says astronaut says 'Tell my wife I love her very much. While  {FacialExpression} emphatically");
        }

        public void EatPie(string typeOfPie)
        {
            if (typeOfPie == "apple")
                Console.WriteLine("Mmmm Pie");
            else
                Console.WriteLine("Awkwaaaarrrrrd....");
        }
    }

    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Orange,
    }
}
