using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class OutingsRepository
    {
        List<Outings> _outingsList;  /* = new List<Outings>();*/

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

        public double GetOutingsCostByType(EventType eventType)
        {
            double typeCostSum = 0;
            foreach (Outings outing in _outingsList)
            {
                if (eventType == outing.TypeOfEvent)   //evenType if coming from program UI user input
                {
                    typeCostSum += outing.TotalEventCost;
                } 

            }

            return typeCostSum;

        }
    }
}
