using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    class OutingsRepository
    {
        List<Outings> _outingsList;
        
        public List<Outings> GetOutingsList()
        {
            _outingsList = new List<Outings>();
            return _outingsList;
        }

        public void AddOutingsToList(Outings outings)
        {
            _outingsList.Add(outings);

        }

    }
}
