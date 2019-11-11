using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartTransaction
    {
        public PartTransaction()
        {
            SerialPartTransaction = new HashSet<SerialPartTransaction>();
            ToolKitTransaction = new HashSet<ToolKitTransaction>();
        }

        public int PartTransactionId { get; set; }
        public int? PartTransactionMaintenanceOrderId { get; set; }
        public int? PartTransactionLocationId { get; set; }
        public int PartTransactionPartId { get; set; }
        public double PartTransactionQuantity { get; set; }
        public int PartTransactionUserId { get; set; }
        public long PartTransactionDateTime { get; set; }
        public int PartTransactionCheckOutInType { get; set; }
        public int? PartTransactionSubLocationId { get; set; }
        public int? PartTransactionBinNo { get; set; }

        public virtual Location PartTransactionLocation { get; set; }
        public virtual MaintenanceOrder PartTransactionMaintenanceOrder { get; set; }
        public virtual Part PartTransactionPart { get; set; }
        public virtual User PartTransactionUser { get; set; }
        public virtual ICollection<SerialPartTransaction> SerialPartTransaction { get; set; }
        public virtual ICollection<ToolKitTransaction> ToolKitTransaction { get; set; }
    }
}
