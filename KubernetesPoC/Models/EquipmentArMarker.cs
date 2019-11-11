using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentArMarker
    {
        public int EquipmentArMarkerId { get; set; }
        public int EquipmentArMarkerEquipmentId { get; set; }
        public string EquipmentArMarkerImage { get; set; }
        public long EquipmentArMarkerXpos { get; set; }
        public long EquipmentArMarkerYpos { get; set; }
        public int EquipmentArMarkerAngle { get; set; }
        public int Type { get; set; }

        public virtual Equipment EquipmentArMarkerEquipment { get; set; }
    }
}
