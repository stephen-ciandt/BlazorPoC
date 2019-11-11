using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReportFilterOption
    {
        public int ReportFilterOptionId { get; set; }
        public int? ReportFilterOptionFilterTypeId { get; set; }
        public int? ReportFilterOptionOptionId { get; set; }
        public string ReportFilterOptionOptionName { get; set; }

        public virtual ReportFilterType ReportFilterOptionFilterType { get; set; }
    }
}
