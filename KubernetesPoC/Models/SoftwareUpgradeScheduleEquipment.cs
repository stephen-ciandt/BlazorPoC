using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SoftwareUpgradeScheduleEquipment
    {
        public int SoftwareUpgradeScheduleEquipmentId { get; set; }
        public int SoftwareUpgradeScheduleEquipmentSoftwareUpgradeScheduleId { get; set; }
        public int SoftwareUpgradeScheduleEquipmentEquipmentId { get; set; }
        public int SoftwareUpgradeScheduleEquipmentStatus { get; set; }

        public virtual Equipment SoftwareUpgradeScheduleEquipmentEquipment { get; set; }
        public virtual SoftwareUpgradeSchedule SoftwareUpgradeScheduleEquipmentSoftwareUpgradeSchedule { get; set; }
    }
}
