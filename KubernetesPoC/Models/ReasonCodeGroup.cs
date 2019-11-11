using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReasonCodeGroup
    {
        public ReasonCodeGroup()
        {
            EquipmentReasonCodeGroupMembers = new HashSet<EquipmentReasonCodeGroupMembers>();
            ReasonCodeGroupMembers = new HashSet<ReasonCodeGroupMembers>();
        }

        public int ReasonCodeGroupId { get; set; }
        public string ReasonCodeGroupName { get; set; }
        public string ReasonCodeGroupDescription { get; set; }
        public string ReasonCodeGroupCreatedBy { get; set; }
        public long ReasonCodeGroupCreatedDate { get; set; }
        public int? Type { get; set; }
        public int ReasonCodeGroupControlFlag { get; set; }
        public bool ReasonCodeGroupIsDeleted { get; set; }
        public Guid? ReasonCodeGroupReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<EquipmentReasonCodeGroupMembers> EquipmentReasonCodeGroupMembers { get; set; }
        public virtual ICollection<ReasonCodeGroupMembers> ReasonCodeGroupMembers { get; set; }
    }
}
