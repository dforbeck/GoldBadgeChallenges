using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public enum Doors{DoorOne, DoorTwo, DoorThree, DoorFour}

    public class Badges
    {
        public int BadgeID { get; set; }
        public Doors DoorNames { get; set; }

        public Badges()
        {
        }

        public Badges(int badgeID, Doors doorNames )
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }


    }

    
}
