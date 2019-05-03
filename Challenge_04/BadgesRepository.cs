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
            return _badgeDictionary;
        }

        public void AddDoorsToBadge(int badge, Badge doors)
        {
            _badgeDictionary.Add(badge, doors);
        }

        public void AddBadge(int badgeInput, Badge doors)
        {
            _badgeDictionary.Add(badgeInput, doors);
        }

        public void DeleteBadge(int badge)
        {
            _badgeDictionary.Remove(badge);
        }

        public void AddDoor(int badgeID, string doorToAdd)
        {
            foreach(KeyValuePair<int, Badge> badge in _badgeDictionary)
            {
                if badge.Key == badgeID)
                {
                    foreach(int doorID in badge.Value)
                    {
                        if doorID == doorToAdd)
                        {
                            badge.Value.Add(doorID);
                        }

                    }
                }
            }
        }

        internal void RemoveDoor(int badgeID)
        {
           
        }
    }
}
