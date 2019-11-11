using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class LicenseDetails
    {
        public int LicenseDetailsId { get; set; }
        public string LicenseDetailsOrgCode { get; set; }
        public string LicenseDetailsLicenseString { get; set; }
        public string LicenseDetailsHostKey { get; set; }
        public long LicenseDetailsAppliedOn { get; set; }
        public int LicenseDetailsAppliedBy { get; set; }
    }
}
