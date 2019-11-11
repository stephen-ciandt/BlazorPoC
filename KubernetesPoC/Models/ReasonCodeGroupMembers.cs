using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReasonCodeGroupMembers
    {
        public int ReasonCodeGroupMembersId { get; set; }
        public int ReasonCodeGroupMembersReasonCodeGroupId { get; set; }
        public int ReasonCodeGroupMembersReasonCodeId { get; set; }

        public virtual ReasonCode ReasonCodeGroupMembersReasonCode { get; set; }
        public virtual ReasonCodeGroup ReasonCodeGroupMembersReasonCodeGroup { get; set; }
    }
}
