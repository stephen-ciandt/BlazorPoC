using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentCostCenterHistory
    {
        public int EquipmentCostCenterHistoryId { get; set; }
        public int EquipmentCostCenterHistoryEquipmentId { get; set; }
        public int? EquipmentCostCenterHistoryCostCenterId { get; set; }
        public long EquipmentCostCenterHistoryUpdateTime { get; set; }
        public string EquipmentCostCenterHistoryByUser { get; set; }

        public virtual CostCenter EquipmentCostCenterHistoryCostCenter { get; set; }
        public virtual Equipment EquipmentCostCenterHistoryEquipment { get; set; }
    }
}
