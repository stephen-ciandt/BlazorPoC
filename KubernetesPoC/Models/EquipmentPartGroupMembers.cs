using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentPartGroupMembers
    {
        public int EquipmentPartGroupMembersId { get; set; }
        public int EquipmentPartGroupMembersEquipmentId { get; set; }
        public int EquipmentPartGroupMembersPartGroupId { get; set; }

        public virtual Equipment EquipmentPartGroupMembersEquipment { get; set; }
        public virtual PartGroup EquipmentPartGroupMembersPartGroup { get; set; }
    }
}
