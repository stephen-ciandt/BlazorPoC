using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetMonitorThreshold
    {
        public int AssetMonitorThresholdId { get; set; }
        public string AssetMonitorThresholdName { get; set; }
        public decimal? AssetMonitorThresholdLowerLimit { get; set; }
        public decimal? AssetMonitorThresholdUpperLimit { get; set; }
        public bool AssetMonitorThresholdEnabled { get; set; }
    }
}
