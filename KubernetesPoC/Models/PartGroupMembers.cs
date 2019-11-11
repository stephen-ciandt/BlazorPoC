using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartGroupMembers
    {
        public int PartGroupMembersId { get; set; }
        public int PartGroupMembersPartGroupId { get; set; }
        public int PartGroupMembersPartId { get; set; }

        public virtual Part PartGroupMembersPart { get; set; }
        public virtual PartGroup PartGroupMembersPartGroup { get; set; }
    }
}
