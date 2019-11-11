using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MobileAppVersion
    {
        public int MobileAppVersionId { get; set; }
        public string MobileAppVersionName { get; set; }
        public string MobileAppVersionVersionNumber { get; set; }
        public bool MobileAppVersionActive { get; set; }
        public string MobileAppVersionFileName { get; set; }
        public bool MobileAppVersionIsUrl { get; set; }
        public string MobileAppVersionDescription { get; set; }
        public string MobileAppVersionCreatedBy { get; set; }
        public long MobileAppVersionCreatedDate { get; set; }
        public Guid? MobileAppVersionReferenceId { get; set; }
    }
}
