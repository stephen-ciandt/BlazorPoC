using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCountPart
    {
        public CycleCountPart()
        {
            CycleCountSerialPart = new HashSet<CycleCountSerialPart>();
        }

        public int Id { get; set; }
        public int PartId { get; set; }
        public long CycleCountId { get; set; }
        public int PartCycleCountStatus { get; set; }
        public int CycleCountState { get; set; }
        public double? SystemCount { get; set; }

        public virtual CycleCount CycleCount { get; set; }
        public virtual Part Part { get; set; }
        public virtual ICollection<CycleCountSerialPart> CycleCountSerialPart { get; set; }
    }
}
