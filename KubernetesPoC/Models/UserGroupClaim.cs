using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserGroupClaim
    {
        public int UserGroupClaimId { get; set; }
        public int UserGroupClaimUserGroupId { get; set; }
        public int UserGroupClaimClaimId { get; set; }

        public virtual ClaimMaster UserGroupClaimClaim { get; set; }
        public virtual UserGroup UserGroupClaimUserGroup { get; set; }
    }
}
