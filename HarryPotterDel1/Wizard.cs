using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterDel1
{
    public class Wizard : House
    {
        public string BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " " + BloodStatus + " " + DumbledoresArmy + " " + DeathEater;
        }

    }
}
