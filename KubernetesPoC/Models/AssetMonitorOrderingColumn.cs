using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetMonitorOrderingColumn
    {
        public int AssetMonitorOrderingColumnId { get; set; }
        public int? AssetMonitorOrderingColumnAssetSubTypeId { get; set; }
        public string AssetMonitorOrderingColumnAssetMonitorColumnsColumnName { get; set; }
        public bool? AssetMonitorOrderingColumnIsAscending { get; set; }
        public int? AssetMonitorOrderingColumnSequence { get; set; }
    }
}
