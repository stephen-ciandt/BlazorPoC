using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetMonitorColumns
    {
        public AssetMonitorColumns()
        {
            AssetMonitorFilters = new HashSet<AssetMonitorFilters>();
        }

        public int AssetMonitorColumnsId { get; set; }
        public int AssetMonitorColumnsAssetMonitorId { get; set; }
        public string AssetMonitorColumnsColumnName { get; set; }
        public string AssetMonitorColumnsColumnDataType { get; set; }
        public string AssetMonitorColumnsColumnType { get; set; }
        public string AssetMonitorColumnsViewName { get; set; }
        public string AssetMonitorColumnsViewColumn { get; set; }
        public int? AssetMonitorColumnsSequence { get; set; }
        public bool AssetMonitorColumnsIsDisplay { get; set; }
        public bool AssetMonitorColumnsIsFilterable { get; set; }

        public virtual AssetMonitor AssetMonitorColumnsAssetMonitor { get; set; }
        public virtual ICollection<AssetMonitorFilters> AssetMonitorFilters { get; set; }
    }
}
