using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReplenishStock
    {
        public int ReplenishStockId { get; set; }
        public string ReplenishStockPono { get; set; }
        public string ReplenishStockPrimaryVendorId { get; set; }
        public int ReplenishStockPartId { get; set; }
        public int ReplenishStockAreaId { get; set; }
        public int ReplenishStockLocationId { get; set; }
        public int? ReplenishStockSubLocationId { get; set; }
        public int? ReplenishStockBinId { get; set; }
        public int ReplenishStockOrderedQty { get; set; }
        public int ReplenishStockReceivedQty { get; set; }
        public int? ReplenishStockRejectedQty { get; set; }
        public string ReplenishStockCreatedBy { get; set; }
        public long ReplenishStockCreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public long LastUpdatedTimeStamp { get; set; }
    }
}
