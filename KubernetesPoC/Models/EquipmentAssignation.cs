using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentAssignation
    {
        public int EquipmentAssignationId { get; set; }
        public int EquipmentAssignationEquipmentId { get; set; }
        public int? EquipmentAssignationUserId { get; set; }
        public string EquipmentAssignationUserName { get; set; }
        public string EquipmentAssignationEquipmentName { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Equipment EquipmentAssignationEquipment { get; set; }
        public virtual User EquipmentAssignationUser { get; set; }
    }
}
