using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentCurrentState
    {
        public int EquipmentCurrentStateId { get; set; }
        public int EquipmentCurrentStateEquipmentId { get; set; }
        public string EquipmentCurrentStateState { get; set; }
        public string EquipmentCurrentStateEquipmentName { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Equipment EquipmentCurrentStateEquipment { get; set; }
    }
}
