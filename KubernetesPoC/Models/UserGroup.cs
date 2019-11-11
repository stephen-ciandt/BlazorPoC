using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            AreaNotificationUserGroupMembers = new HashSet<AreaNotificationUserGroupMembers>();
            AuditNotificationUserGroups = new HashSet<AuditNotificationUserGroups>();
            CycleCountResources = new HashSet<CycleCountResources>();
            EscalationNotificationUserGroupMembers = new HashSet<EscalationNotificationUserGroupMembers>();
            MoResources = new HashSet<MoResources>();
            MoTemplateResourceEstimate = new HashSet<MoTemplateResourceEstimate>();
            PreCompiledCheckListUserGroup = new HashSet<PreCompiledCheckListUserGroup>();
            StockingNotificationUserGroups = new HashSet<StockingNotificationUserGroups>();
            User = new HashSet<User>();
            UserGroupClaim = new HashSet<UserGroupClaim>();
            UserGroupMembers = new HashSet<UserGroupMembers>();
        }

        public int UserGroupId { get; set; }
        public string UserGroupName { get; set; }
        public string UserGroupDescription { get; set; }
        public string UserGroupEmailId { get; set; }
        public string UserGroupCreatedBy { get; set; }
        public long UserGroupCreatedDate { get; set; }
        public int UserGroupControlFlag { get; set; }
        public bool UserGroupIsDeleted { get; set; }
        public Guid? UserGroupReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<AreaNotificationUserGroupMembers> AreaNotificationUserGroupMembers { get; set; }
        public virtual ICollection<AuditNotificationUserGroups> AuditNotificationUserGroups { get; set; }
        public virtual ICollection<CycleCountResources> CycleCountResources { get; set; }
        public virtual ICollection<EscalationNotificationUserGroupMembers> EscalationNotificationUserGroupMembers { get; set; }
        public virtual ICollection<MoResources> MoResources { get; set; }
        public virtual ICollection<MoTemplateResourceEstimate> MoTemplateResourceEstimate { get; set; }
        public virtual ICollection<PreCompiledCheckListUserGroup> PreCompiledCheckListUserGroup { get; set; }
        public virtual ICollection<StockingNotificationUserGroups> StockingNotificationUserGroups { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserGroupClaim> UserGroupClaim { get; set; }
        public virtual ICollection<UserGroupMembers> UserGroupMembers { get; set; }
    }
}
