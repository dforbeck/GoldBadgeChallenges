using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class ProgramUI
    {
        BadgesRepository _badgesRepo = new BadgesRepository();
        Dictionary<int, Badge> _badgeDictionary; //here it is on the shelf!  It's available

        int _response;

        public void Run()
        {
            _badgeDictionary = _badgesRepo.GetBadgeDictionary(); // Now I get it off the shelf and use it.
            SeedData();

            while (_response !=4) //#4 is Exit Choice on menu
            {
                PrintMenu();

                switch (_response)
                {
                    case 1: //Add badge to the dictionary
                        AddBadge();
                        break;
                    case 2: // Edit a badge
                        EditBadge();
                        break;

                    case 3: //List all badges

                        break;
                    case 4: //Exit
                        Console.WriteLine("Ok, then.  Bye!");
                        break;

                    default:
                        Console.WriteLine("Please enter an appropriate number.");
                        break;

                }
            }
        }

        public void EditBadge()
        {
            _badgesRepo.GetBadgeDictionary();

            Console.WriteLine("What is the badge number you want to update?  Enter number and press Enter.\n\t");
            string badgeIDStr = Console.ReadLine();
            int badgeIDInput = int.Parse(badgeIDStr);
            int badgeID = badgeIDInput;

            Console.WriteLine("What would you like to do?\n\t"+
                "1. Remove a Door\n\t"+
                "2. Add a Door");
            int editBadgeInput = int.Parse(Console.ReadLine());

                switch (editBadgeInput)
                {
                case 1:
                    Console.WriteLine("Which door would you like to remove? Press a number and press Enter"+
                    "1. Door 1\n\t" +
                    "2. Door 2\n\t" +
                    "3. Door 3\n\t" +
                    "4. Door 4\n\t");
                    
                    _badgesRepo.RemoveDoor(badgeID, Badge);
                    break;

                case 2:
                    _badgesRepo.AddDoor(badgeID);
                    break;

                default:
                    break;
                }
                




            /*
var item = yourDictionary[theId]; // fetch
            item.Country = "England"; // mutate
            yourDictionary[theId] = item; // overwrite */
        }
        


        public void AddBadge()
        {
            Badge badge = new Badge();
            Console.WriteLine("What is the number of the badge\n\t");
            string badgeIDStr = Console.ReadLine();
            int badgeID = int.Parse(badgeIDStr);

            bool hasAccess = true;
            while (hasAccess)
            {
                Console.WriteLine("List the door that it needs acess to.  Please enter a number and press enter.\n\t"+
                "1. Door 1\n\t"+
                "2. Door 2\n\t"+
                "3. Door 3\n\t"+
                "4. Door 4\n\t");
                int doorInput = int.Parse(Console.ReadLine());
                badge = _badgesRepo.SetAccessFromInput(badge, doorInput);

                Console.WriteLine("Do you want to add another door? Y/N");
                string moreDoors= Console.ReadLine().ToLower();
                    if (moreDoors.Contains("y"))
                    hasAccess = true; 
                    else
                    hasAccess = false;
            }
                _badgesRepo.AddBadgeToDictionary(badge);

        }

        public void SeedData()
        {
            _badgesRepo.AddBadgeToDictionary(new Badge(123, true, false, false, false));

            _badgesRepo.AddBadgeToDictionary(new Badge(345, true, true, false, false));

            _badgesRepo.AddBadgeToDictionary(new Badge(678, true, true, true, true));
        }

        public void PrintMenu()
        {
            Console.WriteLine(
                "Hello Security Admin, What would you like to do?  Please enter a number and press Enter.\n\t"+
                "1. Add a badge\n\t"+
                "2. Edit a badge\n\t"+
                "3. List all badges\n\t"+
                "4. Exit");

            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }
    }
}
