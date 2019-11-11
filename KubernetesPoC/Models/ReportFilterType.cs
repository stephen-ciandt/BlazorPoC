using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReportFilterType
    {
        public ReportFilterType()
        {
            ReportFilter = new HashSet<ReportFilter>();
            ReportFilterOption = new HashSet<ReportFilterOption>();
        }

        public int ReportFilterTypeId { get; set; }
        public string ReportFilterTypeName { get; set; }
        public string ReportFilterTypeInputType { get; set; }

        public virtual ICollection<ReportFilter> ReportFilter { get; set; }
        public virtual ICollection<ReportFilterOption> ReportFilterOption { get; set; }
    }
}
