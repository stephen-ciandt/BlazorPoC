using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentReasonCodeGroupMembers
    {
        public int EquipmentReasonCodeGroupMembersId { get; set; }
        public int EquipmentReasonCodeGroupMembersEquipmentId { get; set; }
        public int EquipmentReasonCodeGroupMembersRcgfor { get; set; }
        public int EquipmentReasonCodeGroupMembersRcgid { get; set; }

        public virtual Equipment EquipmentReasonCodeGroupMembersEquipment { get; set; }
        public virtual ReasonCodeGroup EquipmentReasonCodeGroupMembersRcg { get; set; }
    }
}
