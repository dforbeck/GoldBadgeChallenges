using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    internal class ProgramUI
    {
        ClaimRepository _claimRepo = new ClaimRepository();
        Queue<Claim> _claimQueue;

        int _response; //response from menu

        public void Run()
        {
            _claimQueue = _claimRepo.GetClaimQueue();
            SeedData();

            while (_response != 4) //#4 is Exit choice on menu 
            {
                PrintMenu();
                switch (_response)
                {
                    case 1: //See claims

                        SeeAllClaimsQ();

                        break;

                    case 2: //Take care of next claim in queue
                        TakeCareofClaim();

                        break;

                    case 3: //Add claim to queue
                        GetUserInputforQueue();

                        break;

                    case 4: //exit
                        Console.WriteLine("Great Job!  Have a nice day!");

                        break;

                    default:
                        Console.WriteLine("Please enter an appropriate number");

                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        private void TakeCareofClaim()
        {
            Console.WriteLine($"Here are the details for the next claim to be handled: ID#{_claimQueue.Peek().ClaimID}");
            Console.WriteLine("Do you want to deal with this claim now (Y/N)?");
            string dealNowStr = Console.ReadLine().ToLower();
            bool dealNow = false;
            if (dealNowStr.Contains("y"))
                dealNow = true;

            if (dealNow)
            {
                Console.WriteLine($"Thank you for dealing with the claim ID# {_claimQueue.Peek().ClaimID}!");
                _claimRepo.DequeueClaimFromQueue();
            }
            else
            {
                Console.WriteLine("No claim was removed from the queue.");
            }


        }

        private void GetUserInputforQueue()
        {
            Claim newClaim = new Claim();

            Console.WriteLine("Enter the Claim ID");
            int claimID = int.Parse(Console.ReadLine());
            newClaim.ClaimID = claimID;

            Console.WriteLine("What type of Claim is it?\n\t" +
                "1. Car\n\t" +
                "2. Home\n\t" +
                "3. Theft\n\t"
                );

            int typeInput = int.Parse(Console.ReadLine());
            ClaimType type = _claimRepo.GetTypeFromInput(typeInput);
            newClaim.TypeOfClaim = type;

            Console.WriteLine("Please enter a Description of event");
            string description = Console.ReadLine();
            newClaim.Description = description;

            Console.WriteLine("Please enter the Amount of the claim\n\tExample: 5000.89");
            double amount = double.Parse(Console.ReadLine());
            newClaim.ClaimAmount = amount;

            Console.WriteLine("Please enter incident date\n\tExample: mm/dd/yyyy");
            DateTime incidentDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfIncident = incidentDate;


            Console.WriteLine("Please enter Claim date\n\tExample: mm/dd/yyyy");
            DateTime claimDate = DateTime.Parse(Console.ReadLine());
            newClaim.DateOfClaim = claimDate;

            Console.WriteLine($"Is Claim valid? i.e. is {claimDate} less than or equal to 30 days from {incidentDate}? (Y/N)");
            string isValidStr = Console.ReadLine().ToLower();
            bool isValid;
            if (isValidStr.Contains("y"))
                isValid = true;
            else
                isValid = false;
            newClaim.IsValid = isValid;


            _claimRepo.AddClaimToQueue(newClaim); //Adds new claim with all above details to queue.
        }

        private void SeeAllClaimsQ()
        {
            Console.WriteLine("Claim ID\tClaim Type\tDescription\tAmount\tIncident Date\tClaim Date\tValid Claim?");
            foreach (Claim claim in _claimQueue)
            {
                Console.WriteLine($"{claim.ClaimID}\t{claim.TypeOfClaim }\t{claim.Description}\t{claim.ClaimAmount}\t{claim.DateOfIncident}\t{claim.DateOfClaim}\t{claim.IsValid}");
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine
                (
                "What would you like to do?  Please enter a number and hit Enter.\n\t" +
                "1. See all claims in Queue\n\t" +
                "2. Take care of next claim in Queue\n\t" +
                "3. Enter new claim into Queue\n\t" +
                "4. Exit"
                );

            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        private void SeedData()
        {
            _claimRepo.AddClaimToQueue(new Claim(15, ClaimType.Car, "Crash into pole", 500, DateTime.Parse("11/05/2018"), DateTime.Parse("12/15/2018"), false));

            _claimRepo.AddClaimToQueue(new Claim(10, ClaimType.Home, "Hail", 500, DateTime.Parse("08/05/2018"), DateTime.Parse("08/15/2018"), true));

            _claimRepo.AddClaimToQueue(new Claim(7, ClaimType.Theft, "Home Broken Into", 500, DateTime.Parse("11/05/2018"), DateTime.Parse("11/06/2019"), false));

        }
    }
}