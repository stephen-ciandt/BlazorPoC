using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentLocationHistory
    {
        public int EquipmentLocationHistoryId { get; set; }
        public int EquipmentLocationHistoryEquipmentId { get; set; }
        public int? EquipmentLocationHistoryLocationId { get; set; }
        public long EquipmentLocationHistoryUpdateTime { get; set; }
        public string EquipmentLocationHistoryByUser { get; set; }

        public virtual Equipment EquipmentLocationHistoryEquipment { get; set; }
        public virtual Location EquipmentLocationHistoryLocation { get; set; }
    }
}
