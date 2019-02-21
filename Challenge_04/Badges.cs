using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    /*public enum Doors{DoorOne, DoorTwo, DoorThree, DoorFour}*/

    public class Badges
    {
        public int BadgeID { get; set; }
        public bool AccessDoorOne { get; set; }
        public bool AccessDoorTwo { get; set; }
        public bool AccessDoorThree { get; set; }
        public bool AccessDoorFour { get; set; }

        //empty constructor
        public Badges()
        {
        }

        //overloaded constructor
        public Badges(int badgeID, bool doorOne, bool doorTwo, bool doorThree, bool doorFour)
        {
            BadgeID = badgeID;
            AccessDoorOne = doorOne;
            AccessDoorOne = doorTwo;
            AccessDoorOne = doorThree;
            AccessDoorOne = doorFour;
        }


    }

    
}
