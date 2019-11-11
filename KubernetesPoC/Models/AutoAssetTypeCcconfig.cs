using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AutoAssetTypeCcconfig
    {
        public int Id { get; set; }
        public int AutoAssetTypeCcconfigAppSettingId { get; set; }
        public int AutoAssetTypeCcconfigSelectedAssetType { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
    }
}
