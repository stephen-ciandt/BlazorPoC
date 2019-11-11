using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartSerialNumber
    {
        public PartSerialNumber()
        {
            CycleCountSerialPart = new HashSet<CycleCountSerialPart>();
            SerialPartTransaction = new HashSet<SerialPartTransaction>();
            SerialToolKitTransaction = new HashSet<SerialToolKitTransaction>();
            ToolKitSerialPart = new HashSet<ToolKitSerialPart>();
        }

        public int PartSerialNumberId { get; set; }
        public int PartSerialNumberPartId { get; set; }
        public string PartSerialNumberNumber { get; set; }
        public bool? PartSerialNumberIsAvailable { get; set; }
        public int? PartSerialNumberAreaId { get; set; }
        public int? PartSerialNumberLocationId { get; set; }
        public int? PartSerialNumberSubLocationId { get; set; }
        public int? PartSerialNumberBinNo { get; set; }

        public virtual Part PartSerialNumberPart { get; set; }
        public virtual ICollection<CycleCountSerialPart> CycleCountSerialPart { get; set; }
        public virtual ICollection<SerialPartTransaction> SerialPartTransaction { get; set; }
        public virtual ICollection<SerialToolKitTransaction> SerialToolKitTransaction { get; set; }
        public virtual ICollection<ToolKitSerialPart> ToolKitSerialPart { get; set; }
    }
}
