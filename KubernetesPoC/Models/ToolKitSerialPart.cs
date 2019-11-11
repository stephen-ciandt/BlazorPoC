using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ToolKitSerialPart
    {
        public int ToolKitSerialPartId { get; set; }
        public int ToolKitSerialPartToolKitId { get; set; }
        public int ToolKitSerialPartPartSerialNumberId { get; set; }

        public virtual PartSerialNumber ToolKitSerialPartPartSerialNumber { get; set; }
        public virtual ToolKit ToolKitSerialPartToolKit { get; set; }
    }
}
