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

        public void DeleteBadge(int badge)
        {
            _badgeDictionary.Remove(badge);
        }

        public void AddDoor(int badgeID, int doorToAdd)
        {
            foreach(KeyValuePair<int, Badge> badge in _badgeDictionary)
            {
                if (badge.Key == badgeID)
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

        public void RemoveDoor(int badgeID, int doorToRemove)
        {
            int doorID = doorToRemove;

            foreach (KeyValuePair<int, Badge> badge in _badgeDictionary)
            {
                if (badge.Key == badgeID)
                {
                    foreach (int doorID in badge.Value)
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
