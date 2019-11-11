using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCountSerialPart
    {
        public int CycleCountSerialPartId { get; set; }
        public int CycleCountSerialPartCycleCountPartId { get; set; }
        public int? CycleCountSerialPartPartSerialNumberId { get; set; }
        public string CycleCountSerialPartPartSerialNumber { get; set; }

        public virtual CycleCountPart CycleCountSerialPartCycleCountPart { get; set; }
        public virtual PartSerialNumber CycleCountSerialPartPartSerialNumberNavigation { get; set; }
    }
}
