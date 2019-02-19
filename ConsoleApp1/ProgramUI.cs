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
        int _response; //response from menu
        List<Claim> _claimList;

        public void Run()
        {
            _claimList = _claimRepo.GetClaimList();
            SeedData();

            while (_response != 4)
            {



            }

        }

        private void SeedData()
        {
            _claimRepo.AddClaimToList(new Claim(5, ClaimType.Car, "Crash into pole", 500, DateTime.Parse("11/05/2018"), DateTime.Parse("12/05/2018"), true));

            _claimRepo.AddClaimToList(new Claim(5, ClaimType.Home, "Hail", 500, DateTime.Parse("08/05/2018"), DateTime.Parse("09/05/2018"), true));

            _claimRepo.AddClaimToList(new Claim(5, ClaimType.Theft, "Home Broken Into", 500, DateTime.Parse("11/05/2018"), DateTime.Parse("12/05/2018"), true));

        }
    }
}