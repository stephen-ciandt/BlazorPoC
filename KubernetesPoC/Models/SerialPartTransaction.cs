using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SerialPartTransaction
    {
        public int SerialPartTransactionId { get; set; }
        public int SerialPartTransactionPartTransactionId { get; set; }
        public int SerialPartTransactionPartSerialNumberId { get; set; }
        public int SerialPartTransactionQuantity { get; set; }
        public int SerialPartTransactionCheckOutInType { get; set; }

        public virtual PartSerialNumber SerialPartTransactionPartSerialNumber { get; set; }
        public virtual PartTransaction SerialPartTransactionPartTransaction { get; set; }
    }
}
