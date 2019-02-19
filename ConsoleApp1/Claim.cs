using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public enum ClaimType { Car, Home, Theft}

    public class Claim
    {
        //definte properties
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        //empty constructor
        public Claim()
        {
        }

        //overloaded constructor
        public Claim(int claimID, ClaimType type, string description, double amount, DateTime incidentDate, DateTime claimDate, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = type;
            Description = description;
            ClaimAmount = amount;
            DateOfIncident = incidentDate;
            DateOfClaim = claimDate;
            IsValid = isValid;
        }
    }
}
