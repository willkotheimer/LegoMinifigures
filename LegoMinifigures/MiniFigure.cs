using LegoMinifigures.Pieces.Heads;
using LegoMinifigures.Pieces.Legs;
using LegoMinifigures.Pieces.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class MiniFigure
    {
        public Head Head { get; }
        public Torso Torso { get; }
        public LegsBase Legs { get; }
        public MiniFigure(Head head, Torso torso, LegsBase legs)
        {
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public void MeetSomeone()
        {
            Legs.Walk();
            Torso.Wave();
            Head.Greet();
        }
        
    }
}
