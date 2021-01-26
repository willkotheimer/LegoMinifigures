using System;
using LegoMinifigures.Pieces;
using LegoMinifigures.Pieces.Heads;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.Eyewear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Female;

            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            var skull = new Skull
            {
                Color = Color.Red, 
                Condition = Condition.OnFire, 
                EyeColor = Color.Green, 
                Eyewear = "Aviators"
            };

            var heads = new Head[] {coolHead, nerdHead, skull};

            foreach (var head in heads)
            {
                head.Talk("Stuff");
            }



        }
    }
}
