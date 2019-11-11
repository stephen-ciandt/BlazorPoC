using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetMonitorFilters
    {
        public int AssetMonitorFiltersId { get; set; }
        public int AssetMonitorFiltersAssetMonitorId { get; set; }
        public int AssetMonitorFiltersAssetMonitorColumnsId { get; set; }
        public string AssetMonitorFiltersValue { get; set; }

        public virtual AssetMonitor AssetMonitorFiltersAssetMonitor { get; set; }
        public virtual AssetMonitorColumns AssetMonitorFiltersAssetMonitorColumns { get; set; }
    }
}
