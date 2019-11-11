using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentAttributeHistory
    {
        public int EquipmentAttributeHistoryId { get; set; }
        public int EquipmentAttributeHistoryAttributeId { get; set; }
        public string EquipmentAttributeHistoryAttributeName { get; set; }
        public int EquipmentAttributeHistoryEquipmentId { get; set; }
        public string EquipmentAttributeHistoryEquipmentName { get; set; }
        public string EquipmentAttributeHistoryValue { get; set; }
        public long EquipmentAttributeHistoryTimestamp { get; set; }
        public int EquipmentAttributeHistoryLastUpdatedBy { get; set; }
    }
}
