using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartmentUI
{
    public enum ClaimType
    {
        Car,
        Home,
        Theft
    }
    //POCO
    public class ClaimProperties
    {
        public double ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public decimal DateOfIncident { get; set; }
        public decimal DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ClaimProperties() { }

        public ClaimProperties(double claimID, ClaimType claim, string description, double claimAmount, decimal dateOfIncident, string dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = claim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid; 




        }
    }

        


        }
