using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCountResources
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public int? UserId { get; set; }
        public int? DurationNeededInMins { get; set; }
        public int? DurationUsedInMins { get; set; }
        public long CycleCountId { get; set; }
        public long? ScanOnDateTime { get; set; }
        public long? ScanOffDateTime { get; set; }

        public virtual CycleCount CycleCount { get; set; }
        public virtual User User { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
