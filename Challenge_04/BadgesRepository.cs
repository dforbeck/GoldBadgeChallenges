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

        public void AddBadge(int doorInput, Badge doors)
        {
            _badgeDictionary.Add(doorInput, doors);
        }

        public void DeleteBadge(int badgeID)
        {
            _badgeDictionary.Remove(badgeID);
        }

        public void AddDoor(int badgeID, int doorToAdd)
        {
            foreach(KeyValuePair<int, Badge> badge in _badgeDictionary)
            {
                if (badge.Key == badgeID)
                {
                    foreach (int badgeID in badge.Value)
                    {
                        if doorID == doorToAdd)
                        {
                            badge.Value.Add(doorID);
                        }

                    }
                }
            }
        }

        public void RemoveDoor(int badgeID, int doorToRemove)
        {
            foreach (KeyValuePair<int, Badge> badge in _badgeDictionary)
            {
                if (badge.Key == badgeID)
                {
                    foreach (int badgeID in badge.Value)
                    {
                        if doorID == doorToRemove)
                        {
                            badge.Value.Remove(doorID);
                        }

                    }
                }
            }
        }
    }
}
