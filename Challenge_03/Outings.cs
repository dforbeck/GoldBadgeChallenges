using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public enum EventType { Golf, Bowling, Amusement_Park, Concert}

    class Outings
    {
        //where define the properties
        public int NumberPeople { get; set; }
        public DateTime EventDate { get; set; }
        public EventType TypeOfEvent { get; set; }
	    double CostPerPerson { get; set; }
        public double TotalEventCost { get { return CalculateEventCost(); } }

        public double CalculateEventCost()
        {
            return CostPerPerson * NumberPeople;
        }

        public Outings() // empty constructor
        {
        }

        public Outings(int numberPeople, DateTime eventdate, EventType eventType, double costPerPerson, double totalEventCost)
        {
            NumberPeople = numberPeople;
            TypeOfEvent = eventType;
            CostPerPerson = costPerPerson;
        }
    }
}
