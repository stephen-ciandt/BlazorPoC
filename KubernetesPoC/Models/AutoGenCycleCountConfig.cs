using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AutoGenCycleCountConfig
    {
        public int Id { get; set; }
        public int ItemsCount { get; set; }
        public bool AutoPopulate { get; set; }
        public byte AutoGenerateSchedule { get; set; }
        public byte InventoryCountSchedule { get; set; }
        public byte DaysBeforeOverdue { get; set; }
        public int AutoGenCycleCountConfigControlFlag { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
    }
}
