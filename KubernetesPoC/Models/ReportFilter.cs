using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReportFilter
    {
        public int ReportFilterId { get; set; }
        public int ReportFilterReportId { get; set; }
        public int ReportFilterFilterTypeId { get; set; }

        public virtual ReportFilterType ReportFilterFilterType { get; set; }
        public virtual ReportMaster ReportFilterReport { get; set; }
    }
}
