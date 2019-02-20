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

        public EventType GetTypeFromInput(int typeInput)
        {
            EventType type;
            switch (typeInput)
            {
                case 1:
                    type = EventType.Golf;
                    break;
                case 2:
                    type = EventType.Bowling;
                    break;
                case 3:
                    type = EventType.Amusement_Park;
                    break;
                case 4:
                    type = EventType.Concert;
                    break;
                default:
                    type = EventType.Concert;
                    break;
            }
            return type;


        }

        internal double GetOutingsCostByType(EventType eventType)
        {
            double typecostsum = 0;
            foreach (Outings outing in _outingsList)
            {
                if (eventType == outing.TypeOfEvent)   //eventype if coming from program UI user input
                {
                    typecostsum += outing.TotalEventCost;
                } 

            }

            return typecostsum;

        }
    }
}
