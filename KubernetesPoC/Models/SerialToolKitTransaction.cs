using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SerialToolKitTransaction
    {
        public int SerialToolKitTransactionId { get; set; }
        public int SerialToolKitTransactionToolKitTransactionId { get; set; }
        public int SerialToolKitTransactionPartSerialNumberId { get; set; }
        public int SerialToolKitTransactionQuantity { get; set; }
        public int SerialToolKitTransactionCheckOutInType { get; set; }

        public virtual PartSerialNumber SerialToolKitTransactionPartSerialNumber { get; set; }
        public virtual ToolKitTransaction SerialToolKitTransactionToolKitTransaction { get; set; }
    }
}
