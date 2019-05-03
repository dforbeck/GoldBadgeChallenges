using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
   public class Badge
    {
        public int BadgeID { get; set; }
        public int DoorID { get; set; }
        public string DoorName { get; set; }

        public List<Badge> _badgeDoorList = new List<Badge>() {  
                new Badge(){ DoorID=1, DoorName="One"},
                new Badge(){ DoorID=2, DoorName="Two"},
                new Badge(){ DoorID=3, DoorName="Three"},
            };

        //empty constructor
        public Badge()
        {
        }

        //overloaded constructor
        public Badge(int badgeID, List<Badge> badgeDoorList)
        {
            BadgeID = badgeID;
            _badgeDoorList = badgeDoorList;
        }
    }

    
}
