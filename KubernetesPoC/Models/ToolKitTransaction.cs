using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ToolKitTransaction
    {
        public ToolKitTransaction()
        {
            SerialToolKitTransaction = new HashSet<SerialToolKitTransaction>();
        }

        public int ToolKitTransactionId { get; set; }
        public int ToolKitTransactionPartTransactionId { get; set; }
        public int ToolKitTransactionToolKitId { get; set; }
        public double ToolKitTransactionQuantity { get; set; }
        public long ToolKitTransactionDateTime { get; set; }
        public int ToolKitTransactionCheckOutInType { get; set; }
        public string ToolKitTransactionReason { get; set; }

        public virtual PartTransaction ToolKitTransactionPartTransaction { get; set; }
        public virtual ToolKit ToolKitTransactionToolKit { get; set; }
        public virtual ICollection<SerialToolKitTransaction> SerialToolKitTransaction { get; set; }
    }
}
