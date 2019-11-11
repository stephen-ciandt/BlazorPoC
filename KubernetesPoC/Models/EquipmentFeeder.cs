using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentFeeder
    {
        public int EquipmentFeederId { get; set; }
        public int EquipmentFeederEquipmentId { get; set; }
        public int EquipmentFeederFeederId { get; set; }

        public virtual Equipment EquipmentFeederEquipment { get; set; }
        public virtual Equipment EquipmentFeederFeeder { get; set; }
    }
}
