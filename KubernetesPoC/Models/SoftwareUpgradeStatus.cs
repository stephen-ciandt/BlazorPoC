using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SoftwareUpgradeStatus
    {
        public SoftwareUpgradeStatus()
        {
            SoftwareUpgradeSchedule = new HashSet<SoftwareUpgradeSchedule>();
        }

        public int SoftwareUpgradeStatusId { get; set; }
        public string SoftwareUpgradeStatusName { get; set; }
        public string SoftwareUpgradeStatusDescription { get; set; }

        public virtual ICollection<SoftwareUpgradeSchedule> SoftwareUpgradeSchedule { get; set; }
    }
}
