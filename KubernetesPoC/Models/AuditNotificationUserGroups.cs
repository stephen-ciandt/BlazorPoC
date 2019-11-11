using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AuditNotificationUserGroups
    {
        public int AuditNotificationUserGroupsId { get; set; }
        public int AuditNotificationUserGroupsAreaId { get; set; }
        public int AuditNotificationUserGroupsUserGroupId { get; set; }

        public virtual Area AuditNotificationUserGroupsArea { get; set; }
        public virtual UserGroup AuditNotificationUserGroupsUserGroup { get; set; }
    }
}
