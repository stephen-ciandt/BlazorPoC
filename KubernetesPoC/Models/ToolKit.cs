using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ToolKit
    {
        public ToolKit()
        {
            ToolKitSerialPart = new HashSet<ToolKitSerialPart>();
            ToolKitTransaction = new HashSet<ToolKitTransaction>();
        }

        public int ToolKitId { get; set; }
        public int ToolKitPartId { get; set; }
        public int ToolKitSubPartId { get; set; }
        public double ToolKitQuantity { get; set; }

        public virtual Part ToolKitPart { get; set; }
        public virtual Part ToolKitSubPart { get; set; }
        public virtual ICollection<ToolKitSerialPart> ToolKitSerialPart { get; set; }
        public virtual ICollection<ToolKitTransaction> ToolKitTransaction { get; set; }
    }
}
