using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public class ClaimRepository
    {
        Queue<Claim> _claimQueue = new Queue<Claim>(); //getting the queue

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

        public ClaimType GetTypeFromInput(int typeInput)
        {
            ClaimType type;
            switch (typeInput)
            {
                case 1:
                    type = ClaimType.Car;
                    break;
                case 2:
                    type = ClaimType.Home;
                    break;
                case 3:
                    type = ClaimType.Theft;
                    break;
                default:
                    type = ClaimType.Home;
                    break;
            }
            return type;
        }
       

    }
}
