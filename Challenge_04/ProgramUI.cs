﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class ProgramUI
    {
        BadgesRepository _badgesRepo = new BadgesRepository();
        Dictionary<int, Doors> _badgeDictionary; //here it is on the shelf!  It's available

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

                        break;
                    case 2: // Edit a badge

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

        private void SeedData()
        {
            _badgesRepo.AddBadgeToDictionary(new Badges(123, true, false, false, false));

            _badgesRepo.AddBadgeToDictionary(new Badges(345, true, true, false, false));

            _badgesRepo.AddBadgeToDictionary(new Badges(678, true, true, true, true));
        }

        private void PrintMenu()
        {
            Console.WriteLine(
                "Hello Security Admin, What would you like to do?  Please enter a number and press Enter.\n\t"+
                "1. Add a badge\n\t"+
                "2. Edit a badge\n\t"+
                "3. List all badges\n\t"
                "4. Exit");

            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }
    }
}
