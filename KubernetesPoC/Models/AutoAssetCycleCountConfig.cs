using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AutoAssetCycleCountConfig
    {
        public int Id { get; set; }
        public byte AutoGenerateSchedule { get; set; }
        public byte AssetCountSchedule { get; set; }
        public byte DaysBeforeOverdue { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
    }
}
