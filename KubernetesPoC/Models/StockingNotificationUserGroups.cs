using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class StockingNotificationUserGroups
    {
        public int StockingNotificationUserGroupsId { get; set; }
        public int StockingNotificationUserGroupsAreaId { get; set; }
        public int StockingNotificationUserGroupsUserGroupId { get; set; }

        public virtual Area StockingNotificationUserGroupsArea { get; set; }
        public virtual UserGroup StockingNotificationUserGroupsUserGroup { get; set; }
    }
}
