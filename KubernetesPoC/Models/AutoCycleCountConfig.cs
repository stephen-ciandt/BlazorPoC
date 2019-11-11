using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AutoCycleCountConfig
    {
        public short Id { get; set; }
        public string PartClass { get; set; }
        public byte PercentageValue { get; set; }
        public bool IsActive { get; set; }
        public int AutoCycleCountConfigControlFlag { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
    }
}
