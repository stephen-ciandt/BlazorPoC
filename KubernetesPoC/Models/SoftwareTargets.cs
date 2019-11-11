using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SoftwareTargets
    {
        public int SoftwareTargetsId { get; set; }
        public int SoftwareTargetsSoftwareId { get; set; }
        public int? SoftwareTargetsAreaId { get; set; }
        public string SoftwareTargetsSoftwareVersion { get; set; }
        public long? SoftwareTargetsActiveFrom { get; set; }
        public long? SoftwareTargetsActiveTill { get; set; }

        public virtual Area SoftwareTargetsArea { get; set; }
        public virtual Software SoftwareTargetsSoftware { get; set; }
    }
}
