using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class ProgramUI
    {
        OutingsRepository _outingsRepo = new OutingsRepository();
        int _response; //reponse to menu here

        List<Outings> _outingsList;

        public void Run()
        {
            _outingsList = _outingsRepo.GetOutingsList();
            SeedData();

            while (_response !=5)//5 is Exit
            {
                PrintMenu();
                switch (_response)
                {
                    case 1:
                        DisplayAllOutings();
                        break;

                    case 2:
                        AddOuting();
                        break;

                    case 3:
                        SeeOutingsCostByType();
                        break;

                    case 4:
                        SeeTotalCost();
                        break;

                    case 5:
                        Console.WriteLine("Have a Nice Day!");
                        break;

                    default:
                        Console.WriteLine("Please enter an appropriate number.");
                        break;
                }
            }
        }

        private void SeeTotalCost()
        {

            double totalOutingsCost = _outingsList.Sum(outings => outings.TotalEventCost);

            Console.WriteLine($"This is total costs of all events: {totalOutingsCost}");
        }

        private void SeeOutingsCostByType()
        {
            Console.WriteLine("What type of Outing was it?\n\t" +
               "1. Golf\n\t" +
               "2. Bowling\n\t" +
               "3. Amusement Park\n\t" +
               "4. Concert");
            int typeInput = int.Parse(Console.ReadLine());
            EventType eventType = _outingsRepo.GetTypeFromInput(typeInput);
            double typecost = _outingsRepo.GetOutingsCostByType(eventType);

            Console.WriteLine($"Your cost for the outings {eventType} your total cost was {typecost}");
        }



        private void AddOuting()
        {
            Console.WriteLine("Enter the Outing Number of People\n\t");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);
            
            Console.WriteLine("Enter Event Date\n\tExample:mm/dd/yyyy");
            DateTime outingDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What type of Outing was it?\n\t" +
               "1. Golf\n\t" +
               "2. Bowling\n\t" +
               "3. Amusement Park\n\t"+
               "4. Concert");
            int typeInput = int.Parse(Console.ReadLine());

            EventType type = _outingsRepo.GetTypeFromInput(typeInput);

            Console.WriteLine("Enter the Cost per Person");
            string personCostStr = Console.ReadLine();
            int personCost = int.Parse(personCostStr);

            Outings newOuting = new Outings(number, outingDate, type, personCost);
            _outingsRepo.AddOutingsToList(newOuting);
        }

        public void DisplayAllOutings()
        {
            Console.WriteLine("Number of People\tEvent Date\tEvent Type\tCost per Person\tTotal Event Cost");

            foreach (Outings outings in _outingsList)
            {
                Console.WriteLine($"{outings.NumberPeople}\t{outings.EventDate}\t{outings.TypeOfEvent}\t{outings.CostPerPerson}\t{outings.TotalEventCost}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        
        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?\n\t"+
                "1. Display all Outings\n\t"+
                "2. Add an Outing to the list\n\t"+
                "3. See the Cost of Outings by Type\n\t"+
                "4. See the Total Cost of all Outings\n\t" +
                "5.Exit");
            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        private void SeedData()
        {
            _outingsRepo.AddOutingsToList(new Outings(20, DateTime.Parse("11/05/2018"), EventType.Amusement_Park, 34.50));
            _outingsRepo.AddOutingsToList(new Outings(30, DateTime.Parse("06/05/2018"), EventType.Bowling, 15));
            _outingsRepo.AddOutingsToList(new Outings(20, DateTime.Parse("10/05/2018"), EventType.Concert, 20.75));
        }
    }
}
