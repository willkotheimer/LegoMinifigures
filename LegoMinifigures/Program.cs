using System;
using LegoMinifigures.Pieces;
using LegoMinifigures.Pieces.Heads;
using LegoMinifigures.Pieces.Legs;
using LegoMinifigures.Pieces.Torsos;

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

            var pirateWithHook = new PirateTorso(true) { Clothing = Clothing.SmokingJacket } ;
            var pirateWithoutHook = new PirateTorso(false) { Clothing = Clothing.Tanktop } ;

            pirateWithHook.Wave();
            pirateWithoutHook.Wave();

            var skeletenTorso = new SkeletonTorso(false, Condition.OnFire);

            var policeTorso = new PoliceOfficer();

            var torsos = new Torso[] { pirateWithoutHook, pirateWithHook, skeletenTorso, policeTorso };

            foreach(var body in torsos)
            {
                body.Wave();
            }


            var skullPoliceSpider = new MiniFigure(skull, policeTorso, new SpiderLegs());

            skullPoliceSpider.MeetSomeone();


        }
    }
}
