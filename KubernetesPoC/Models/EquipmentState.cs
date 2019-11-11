using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentState
    {
        public int EquipmentStateId { get; set; }
        public string EquipmentStateName { get; set; }
        public string EquipmentStateDescription { get; set; }
    }
}
