using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaNotificationUserGroupMembers
    {
        public int AreaNotificationUserGroupMembersId { get; set; }
        public int AreaNotificationUserGroupMembersAreaId { get; set; }
        public int AreaNotificationUserGroupMembersUserGroupId { get; set; }
        public int AreaNotificationUserGroupMembersPriority { get; set; }

        public virtual Area AreaNotificationUserGroupMembersArea { get; set; }
        public virtual UserGroup AreaNotificationUserGroupMembersUserGroup { get; set; }
    }
}
