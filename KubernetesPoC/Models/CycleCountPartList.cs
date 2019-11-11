using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCountPartList
    {
        public long CycleCountId { get; set; }
        public int PartId { get; set; }

        public virtual CycleCount CycleCount { get; set; }
        public virtual Part Part { get; set; }
    }
}
