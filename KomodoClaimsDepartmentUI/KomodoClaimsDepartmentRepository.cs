using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartmentUI
{
    class KomodoClaimsDepartmentRepository
    {
        public List<ClaimProperties> _listofClaims = new List<ClaimProperties>();

        //Create
        public void AddClaimToList(ClaimProperties claims)
        {
            _listofClaims.Add(claims);
        }

        
          
            

        //Read
        public List<ClaimProperties> GetListofClaims()
        {
            return _listofClaims;
        }

        //Update
        public bool UpdateListofClaims (double originalClaimId, ClaimProperties newClaim)
        {
            ClaimProperties oldClaim = GetContentByClaimID(originalClaimId);

            if (oldClaim != null)
            {
                oldClaim.ClaimID = newClaim.ClaimID;
                oldClaim.TypeOfClaim = newClaim.TypeOfClaim;
                oldClaim.Description = newClaim.Description;
                oldClaim.ClaimAmount = newClaim.ClaimAmount;
                oldClaim.DateOfIncident = newClaim.DateOfIncident;
                oldClaim.DateOfClaim = newClaim.DateOfClaim;
                oldClaim.IsValid = newClaim.IsValid;
            }
        }

        //Delete
        public bool RemoveClaimFromList(double ClaimID)
        {
            ClaimProperties content = GetContentByClaimID(ClaimID);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listofClaims.Count;
            _listofClaims.Remove(content);

            if (initialCount > _listofClaims.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
