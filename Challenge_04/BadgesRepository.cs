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
        private object badge;

        public Dictionary<int, List<int>> GetBadgeDictionary()
        {
            return _badgeDictionary;
        }

        public void AddBadge(int doorInput, List<int> doors)
        {
            _badgeDictionary.Add(doorInput, doors);
        }

        public void AddDoor(int badgeID, int doorToAdd)
        {
             _badgeDictionary[badgeID].Add(doorToAdd);  // so much better than below

            foreach (KeyValuePair<int, List<int>> badges in _badgeDictionary)
            {
                if (badges.Key == badgeID)
                    badges.Value.Add(doorToAdd);
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
