using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    

    public class ProgramUI
    {
        public BadgesRepository _badgeRepo = new BadgesRepository();
        Dictionary<int, Badge> _badgeDictionary; //here it is on the shelf!  It's available

        int _response;

        public void Run()
        {
            _badgeDictionary = _badgeRepo.GetBadgeDictionary(); // Now I get it off the shelf and use it

            while (_response !=4) //#4 is Exit Choice on menu
            {
                PrintMenu();

                switch (_response)
                {
                    case 1: //Add badge to the dictionary
                        AddBadgeAndDoor();
                        break;
                    case 2: // Edit a badge
                        EditBadge();
                        break;

                    case 3: //Delete badge
                        DeleteBadge();
                        break;

                    case 4: //List all badges
                        ListAllBadges();
                        break;

                    case 5: //Exit
                        Console.WriteLine("Ok, then.  Bye!");
                        break;

                    default:
                        Console.WriteLine("Please enter an appropriate number.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }


        public void AddBadgeAndDoor()
        {
            Badge badge = new Badge();
          
            bool hasAccess = true;
            while (hasAccess)
            {
                Console.WriteLine("List the door that it needs acess to.  Please type a number and press enter.\n\t" +
                "1. Door 1\n\t" +
                "2. Door 2\n\t" +
                "3. Door 3\n\t");

                int doorInput = int.Parse(Console.ReadLine());
                int BadgeID = doorInput;
                _badgeRepo.AddBadge(BadgeID, badge);

                Console.WriteLine("Do you want to add another door? Y/N");
                string moreDoors = Console.ReadLine().ToLower();
                if (moreDoors.Contains("y"))
                    hasAccess = true;
                else
                    hasAccess = false;
            }
        }
        
        public void EditBadge()
        {
            _badgeRepo.GetBadgeDictionary();

            Console.WriteLine("What is the badge number you want to update?  Enter number and press Enter.\n\t");
            string badgeIDStr = Console.ReadLine();
            int badgeIDInput = int.Parse(badgeIDStr);
            int badgeID = badgeIDInput;

            Console.WriteLine("What would you like to do?\n\t" +
                "1. Remove a Door\n\t" +
                "2. Add a Door");
            int editBadgeInput = int.Parse(Console.ReadLine());

            switch (editBadgeInput)
            {
                case 1:
                    Console.WriteLine("Which door would you like to remove? Press a number and press Enter" +
                    "1. Door 1\n\t" +
                    "2. Door 2\n\t" +
                    "3. Door 3\n\t");
                    string doorStr = Console.ReadLine();
                    int doorInput = int.Parse(doorStr);
                    int doorToRemove = doorInput;

                    _badgeRepo.RemoveDoor(badgeID, doorToRemove);
                    break;

                case 2:
                    AddBadgeAndDoor();
                    break;

                default:
                    break;
            }
        }  

        public void ListAllBadges()
            {

           _badgeDictionary = _badgeRepo.GetBadgeDictionary();

            Console.WriteLine("BadgeID\tDoorID\tDoorName");

                foreach (Badge badge in _badgeDictionary)
                {
                    Console.WriteLine($"{badge.BadgeID}\t{badge.DoorID}\t{badge.DoorName}");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        public void DeleteBadge()
        {
            _badgeRepo.GetBadgeDictionary();

            Console.WriteLine("What is the badge number you want to delete?  Enter number and press Enter.\n\t");
            string badgeIDStr = Console.ReadLine();
            int badgeIDInput = int.Parse(badgeIDStr);
            int badgeID = badgeIDInput;

            _badgeRepo.DeleteBadge(badgeID);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }


        public void PrintMenu()
        {
            Console.WriteLine(
                "Hello Security Admin, What would you like to do?  Please enter a number and press Enter.\n\t"+
                "1. Add a badge\n\t"+
                "2. Edit a badge\n\t"+
                "3. Delete a badge\n\t"+
                "4. List all badges\n\t"+
                "5. Exit");

            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }
    }
}
