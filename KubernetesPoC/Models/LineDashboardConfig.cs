using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class LineDashboardConfig
    {
        public int LineDashboardConfigId { get; set; }
        public int LineDashboardConfigAreaId { get; set; }
        public string LineDashboardConfigConfigData { get; set; }

        public virtual Area LineDashboardConfigArea { get; set; }
    }
}
