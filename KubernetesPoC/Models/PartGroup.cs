using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartGroup
    {
        public PartGroup()
        {
            EquipmentPartGroupMembers = new HashSet<EquipmentPartGroupMembers>();
            PartGroupMembers = new HashSet<PartGroupMembers>();
        }

        public int PartGroupId { get; set; }
        public string PartGroupName { get; set; }
        public string PartGroupDescription { get; set; }
        public int? Type { get; set; }
        public int PartGroupControlFlag { get; set; }
        public bool PartGroupIsDeleted { get; set; }
        public Guid? PartGroupReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<EquipmentPartGroupMembers> EquipmentPartGroupMembers { get; set; }
        public virtual ICollection<PartGroupMembers> PartGroupMembers { get; set; }
    }
}
