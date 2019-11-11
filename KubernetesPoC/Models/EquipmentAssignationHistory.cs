using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentAssignationHistory
    {
        public int EquipmentAssignationHistoryId { get; set; }
        public string EquipmentAssignationHistoryEquipmentName { get; set; }
        public string EquipmentAssignationHistoryUserName { get; set; }
        public long? EquipmentAssignationHistoryStartDate { get; set; }
        public long? EquipmentAssignationHistoryEndDate { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
