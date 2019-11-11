using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SoftwareVersion
    {
        public int SoftwareVersionId { get; set; }
        public int SoftwareVersionSoftwareId { get; set; }
        public bool SoftwareVersionIsValid { get; set; }
        public string SoftwareVersionVersionNumber { get; set; }
        public string SoftwareVersionFileName { get; set; }
        public string SoftwareVersionCreatedBy { get; set; }
        public long SoftwareVersionCreatedDate { get; set; }

        public virtual Software SoftwareVersionSoftware { get; set; }
    }
}
