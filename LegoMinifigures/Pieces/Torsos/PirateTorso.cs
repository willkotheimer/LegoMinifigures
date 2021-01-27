using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Torsos
{
    class PirateTorso : Torso
    {
        public bool HasHook { get; private set; }

        public PirateTorso(bool hasHook)
        {

            Accessory = "Parrot";
            HasHook = hasHook;
        }

        public override void Wave()
        {
            if(HasHook)
            {
                Console.WriteLine($"The pirate torso waves with his hook.");
            } else
            {
                Console.WriteLine($"The pirate waves happily.");

            }
        }
    }
}
