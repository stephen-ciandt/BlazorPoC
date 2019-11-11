using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SoftwareAppliesTo
    {
        public int SoftwareAppliesToId { get; set; }
        public int SoftwareAppliesToSoftwareId { get; set; }
        public string SoftwareAppliesToModelNumber { get; set; }

        public virtual Software SoftwareAppliesToSoftware { get; set; }
    }
}
