using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    
    public class BadgesRepository
    {
        Badge badges = new Badge();

        List<Badge> _badgeList;

        public Dictionary<int, Badge > _badgeDictionary = new Dictionary<int, Badge>();
            
         public Dictionary<int, Badge> GetBadgeDictionary()
        {
            _badgeDictionary = new Dictionary<int, Badge>();
            return _badgeDictionary;
        }

        public void AddBadgeToDictionary(Badge badge)
        {

            _badgeDictionary.Add(badge.BadgeID, badge);
        }

        public Badge SetAccessFromInput(Badge badge,int newDoorAccess)
        {
            switch (newDoorAccess)
            {
                case 1:
                    badge.AccessDoorOne = true;
                    break;

                case 2:
                    badge.AccessDoorTwo = true;
                    break;

                case 3:
                    badge.AccessDoorThree = true;
                    break;

                case 4:
                    badge.AccessDoorFour = true;
                    break;

                default:
                    break;

            }
            return badge;

        }

        internal void AddDoor(int badgeID, int door)
        {
            _badgeDictionary[badgeID].


        }

        internal void RemoveDoor(int badgeID)
        {
           
        }
    }
}
