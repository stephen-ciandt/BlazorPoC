using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaEquipmentMembers
    {
        public int AreaEquipmentMembersId { get; set; }
        public int AreaEquipmentMembersEquipmentId { get; set; }
        public int AreaEquipmentMembersAreaId { get; set; }
        public int? AreaEquipmentMembersSequenceNumber { get; set; }

        public virtual Area AreaEquipmentMembersArea { get; set; }
        public virtual Equipment AreaEquipmentMembersEquipment { get; set; }
    }
}
