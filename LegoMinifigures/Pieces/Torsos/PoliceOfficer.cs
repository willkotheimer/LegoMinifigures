using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Torsos
{
    class PoliceOfficer : Torso
    {
        public PoliceOfficer()
        {
            Clothing = Clothing.Raincoat;
            Accessory = "badge";
        }
    }
}
