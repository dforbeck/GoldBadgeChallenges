using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    
    public class BadgesRepository
    {
        Badges badges = new Badges();

        List<Badges> _badgeList;

        public Dictionary<int, Badges > _badgeDictionary = new Dictionary<int, Badges>();
            
         public Dictionary<int, Badges> GetBadgeDictionary()
        {
            _badgeDictionary = new Dictionary<int, Badges>();
            return _badgeDictionary;
        }

        public void AddBadgeToDictionary(Badges badge)
        {
            _badgeDictionary.Add(badge.BadgeID, badges);
        }


    }
}
