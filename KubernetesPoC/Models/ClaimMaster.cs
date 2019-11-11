using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ClaimMaster
    {
        public ClaimMaster()
        {
            UserGroupClaim = new HashSet<UserGroupClaim>();
        }

        public int ClaimMasterId { get; set; }
        public string ClaimMasterCategory { get; set; }
        public string ClaimMasterClaim { get; set; }

        public virtual ICollection<UserGroupClaim> UserGroupClaim { get; set; }
    }
}
