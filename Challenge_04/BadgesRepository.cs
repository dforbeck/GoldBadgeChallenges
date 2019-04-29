using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    
    public class BadgesRepository
    {
        public Dictionary<int, Badge> _badgeDictionary = new Dictionary<int, Badge>();
            
        public Dictionary<int, Badge> GetBadgeDictionary()
        {
            _badgeDictionary = new Dictionary<int, Badge>();
            return _badgeDictionary;
        }

        public void AddBadgeToDictionary(Badge badge)
        {
            _badgeDictionary.Add(badge.BadgeID, badge);
        }

        public Dictionary GetDoorNameFromInput(int typeInput)
        {
            Badge type;
            switch (typeInput)
            {
                case 1:
                    type = _doorInput;
                    break;
                case 2:
                    type = ClaimType.Home;
                    break;
                case 3:
                    type = ClaimType.Theft;
                    break;
                default:
                    type = ClaimType.Home;
                    break;
            }
            return type;
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
