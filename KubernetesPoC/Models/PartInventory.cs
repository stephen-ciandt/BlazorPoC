using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartInventory
    {
        public int InventoryId { get; set; }
        public int InventoryPartId { get; set; }
        public int InventoryAreaId { get; set; }
        public int InventoryLocationId { get; set; }
        public int? InventorySubLocationId { get; set; }
        public int? InventoryBinId { get; set; }
        public double InventoryQoh { get; set; }
        public double? InventoryMinimumQuantity { get; set; }
        public double? InventoryMaximumQuantity { get; set; }
        public DateTime? InventoryLastIssueDate { get; set; }
        public double? InventoryIssueQuantityYtd { get; set; }
        public double? InventoryInventoryTurnRatio { get; set; }
        public int PartInventoryIsDefaultLocation { get; set; }
        public int PartInventoryCycleCountFlag { get; set; }

        public virtual Area InventoryArea { get; set; }
        public virtual Bin InventoryBin { get; set; }
        public virtual Location InventoryLocation { get; set; }
        public virtual Part InventoryPart { get; set; }
        public virtual SubLocation InventorySubLocation { get; set; }
    }
}
