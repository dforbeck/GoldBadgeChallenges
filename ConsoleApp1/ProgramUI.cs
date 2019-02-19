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
        List<Claim> _claimList;
        Queue<Claim> _claimQueue;

        int _response; //response from menu

        public void Run()
        {
            _claimList = _claimRepo.GetClaimList();
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
                        Console.WriteLine($"You just took care of the next claim in the queue, {_claimQueue.Peek().ClaimID}");
                        _claimRepo.DequeueClaimFromQueue();
                        break;

                    case 3: //Add claim to queue
                        GetUserInputforQueue();

                        break;

                
                }

            }

        
        }

        private void GetUserInputforQueue()
        {
            throw new NotImplementedException();






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
                "1. See all claims in Queue\n\t"+
                "2. Take care of next claim in Queue\n\t" +
                "3. Enter new claim into Queue\n\t" +
                "4. Exit"
                );

            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        private void SeedData()
        {
            _claimRepo.AddClaimToQueue(new Claim(5, ClaimType.Car, "Crash into pole", 500, DateTime.Parse("11/05/2018"), DateTime.Parse("12/05/2018"), true));

            _claimRepo.AddClaimToQueue(new Claim(5, ClaimType.Home, "Hail", 500, DateTime.Parse("08/05/2018"), DateTime.Parse("09/05/2018"), true));

            _claimRepo.AddClaimToQueue(new Claim(5, ClaimType.Theft, "Home Broken Into", 500, DateTime.Parse("11/05/2018"), DateTime.Parse("12/05/2018"), true));

        }
    }
}