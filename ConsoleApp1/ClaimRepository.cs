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
        Queue<Claim> _claimQueue = new Queue<Claim>();

        public List<Claim> GetClaimList()
        {
            _claimList = new List<Claim>();
            return _claimList;
        }

       public Queue<Claim> GetClaimQueue()
        {
            _claimQueue = new Queue<Claim>();
            return _claimQueue;
        }

        public void DequeueClaimFromQueue()
        {
            _claimQueue.Dequeue();
        }

        public void AddClaimToQueue(Claim claim)
        {
            _claimQueue.Enqueue(claim);
        }
    }
}
