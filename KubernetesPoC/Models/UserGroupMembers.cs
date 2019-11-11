using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserGroupMembers
    {
        public int UserGroupMembersId { get; set; }
        public int UserGroupMembersUserId { get; set; }
        public int UserGroupMembersUserGroupId { get; set; }

        public virtual User UserGroupMembersUser { get; set; }
        public virtual UserGroup UserGroupMembersUserGroup { get; set; }
    }
}
