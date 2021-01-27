using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Legs
{
    abstract class LegsBase
    {
        public string Covering { get; set; }
        public Size Size { get; set; }
        public int Speed { get; set; }
        public string Shoes { get; set; }
        public int NumberOfLegs { get; set; }

        protected string _musicGenre { get; set; } 

        public LegsBase()
        {
            NumberOfLegs = 2;
            Size = Size.Adult;
            Covering = "Pants";
            Speed = 1;
            _musicGenre = "Waltz";

        }
        public virtual void Dance()
        {
            var danceSpeed = Speed > 5 ? "Fast" : "Slow";
            Console.WriteLine($"The {GetType().Name} legs danced { danceSpeed } to { _musicGenre } wearing {Covering} and {Shoes}.");
        }

        public void Walk()
        {
            Console.WriteLine($"The {GetType().Name} legs walked {Speed} steps forward.");
        }
    }
}
