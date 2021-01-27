using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Torsos
{
    abstract class Torso
    {
        public Clothing Clothing { get; set; }
        public Color Color { get; set; }
        public int NumberOfArms { get; set; }
        public string Accessory { get; set; }

        public Torso()
        {
            NumberOfArms = 2;

        }

        //With virtual class the 
        public virtual void Wave()
        {
            if(NumberOfArms > 0)
            {
                Console.WriteLine($"The {GetType().Name} waves hello.");
            } else
            {
                Console.WriteLine($"Can't wave no arms.");
            }
        }

    }
}
