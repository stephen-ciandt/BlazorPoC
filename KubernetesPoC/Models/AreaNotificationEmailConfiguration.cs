using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaNotificationEmailConfiguration
    {
        public int AreaNotificationUserGroupEmailConfigId { get; set; }
        public int AreaNotificationUserGroupMembersAreaId { get; set; }
        public int AreaNotificationUserGroupMembersPriority { get; set; }
        public string AreaNotificationUserGroupEmail { get; set; }

        public virtual Area AreaNotificationUserGroupMembersArea { get; set; }
    }
}
