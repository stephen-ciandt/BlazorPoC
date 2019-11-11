using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EscalationNotificationUserGroupMembers
    {
        public int EscalationNotificationUserGroupMembersId { get; set; }
        public int EscalationNotificationUserGroupMembersGroupId { get; set; }
        public int EscalationNotificationUserGroupMembersUserId { get; set; }
        public int EscalationNotificationUserGroupMembersIsNotify { get; set; }
        public int EscalationNotificationUserGroupMembersEscalationLevel { get; set; }
        public string EscalationNotificationUserGroupMembersCreatedBy { get; set; }
        public long EscalationNotificationUserGroupMembersCreatedDate { get; set; }

        public virtual UserGroup EscalationNotificationUserGroupMembersGroup { get; set; }
        public virtual User EscalationNotificationUserGroupMembersUser { get; set; }
    }
}
