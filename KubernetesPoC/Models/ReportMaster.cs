using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReportMaster
    {
        public ReportMaster()
        {
            ReportFilter = new HashSet<ReportFilter>();
        }

        public int ReportMasterId { get; set; }
        public string ReportMasterName { get; set; }
        public string ReportMasterFunctionName { get; set; }
        public int ReportMasterType { get; set; }

        public virtual ICollection<ReportFilter> ReportFilter { get; set; }
    }
}
