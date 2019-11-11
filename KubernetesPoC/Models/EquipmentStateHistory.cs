using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentStateHistory
    {
        public int EquipmentStateHistoryId { get; set; }
        public string EquipmentStateHistoryState { get; set; }
        public string EquipmentStateHistoryEquipmentName { get; set; }
        public long? EquipmentStateHistoryStartDate { get; set; }
        public long? EquipmentStateHistoryEndDate { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
