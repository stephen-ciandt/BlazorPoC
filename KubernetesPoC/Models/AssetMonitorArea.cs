using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetMonitorArea
    {
        public int AssetMonitorAreaId { get; set; }
        public int AssetMonitorAreaAssetMonitorId { get; set; }
        public int AssetMonitorAreaAreaId { get; set; }

        public virtual Area AssetMonitorAreaArea { get; set; }
        public virtual AssetMonitor AssetMonitorAreaAssetMonitor { get; set; }
    }
}
