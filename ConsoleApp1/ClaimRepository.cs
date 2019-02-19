using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public class ClaimRepository
    {
        List<Claim> _claimList; //naming the list

        public List<Claim> GetClaimList()
        {
            _claimList = new List<Claim>();
            return _claimList;
        }

        public void AddClaimToList(Claim claim)
        {
            _claimList.Add(claim);
        }
    }
}
