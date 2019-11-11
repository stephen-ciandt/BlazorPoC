using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SoftwareUpgradeSchedule
    {
        public SoftwareUpgradeSchedule()
        {
            SoftwareUpgradeScheduleEquipment = new HashSet<SoftwareUpgradeScheduleEquipment>();
        }

        public int SoftwareUpgradeScheduleId { get; set; }
        public int SoftwareUpgradeScheduleSoftwareId { get; set; }
        public int SoftwareUpgradeScheduleAreaId { get; set; }
        public string SoftwareUpgradeScheduleVersionNumber { get; set; }
        public long? SoftwareUpgradeScheduleScheduledDate { get; set; }
        public int SoftwareUpgradeScheduleStatus { get; set; }
        public bool SoftwareUpgradeScheduleAppliesToAll { get; set; }
        public int SoftwareUpgradeScheduleControlFlag { get; set; }
        public bool SoftwareUpgradeScheduleIsDeleted { get; set; }
        public Guid? SoftwareUpgradeScheduleReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Area SoftwareUpgradeScheduleArea { get; set; }
        public virtual Software SoftwareUpgradeScheduleSoftware { get; set; }
        public virtual SoftwareUpgradeStatus SoftwareUpgradeScheduleStatusNavigation { get; set; }
        public virtual ICollection<SoftwareUpgradeScheduleEquipment> SoftwareUpgradeScheduleEquipment { get; set; }
    }
}
