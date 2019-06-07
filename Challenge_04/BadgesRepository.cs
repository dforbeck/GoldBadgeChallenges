using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{

    public class BadgesRepository
    {
        public Dictionary<int, List<int>> _badgeDictionary = new Dictionary<int, List<int>>();

        public Dictionary<int, List<int>> GetBadgeDictionary()
        {
            return _badgeDictionary;
        }

        public void AddBadgeAndDoors(int badgeID, List<int> doors)
        {
            _badgeDictionary.Add(badgeID, doors);
        }

        public void AddDoor(int badgeID, int doorToAdd)
        {
             _badgeDictionary[badgeID].Add(doorToAdd);  // so much better than below
            /*
            foreach (KeyValuePair<int, List<int>> badges in _badgeDictionary)
            {
                if (badges.Key == badgeID)
                    badges.Value.Add(doorToAdd);
            }
            */
        }

        public void RemoveDoor(int badgeID, int doorToRemove)
        {
            _badgeDictionary[badgeID].Remove(doorToRemove);
            
        }
    }
}
