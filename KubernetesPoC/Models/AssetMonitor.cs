using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetMonitor
    {
        public AssetMonitor()
        {
            AssetMonitorArea = new HashSet<AssetMonitorArea>();
            AssetMonitorColumns = new HashSet<AssetMonitorColumns>();
            AssetMonitorFilters = new HashSet<AssetMonitorFilters>();
        }

        public int AssetMonitorId { get; set; }
        public string AssetMonitorName { get; set; }
        public int AssetMonitorControlFlag { get; set; }
        public bool AssetMonitorIsDeleted { get; set; }
        public bool AssetMonitorIsTemplate { get; set; }
        public int? AssetMonitorTemplateId { get; set; }
        public int? AssetMonitorAssetSubTypeId { get; set; }
        public Guid? AssetMonitorReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public string AssetMonitorView { get; set; }

        public virtual ICollection<AssetMonitorArea> AssetMonitorArea { get; set; }
        public virtual ICollection<AssetMonitorColumns> AssetMonitorColumns { get; set; }
        public virtual ICollection<AssetMonitorFilters> AssetMonitorFilters { get; set; }
    }
}
