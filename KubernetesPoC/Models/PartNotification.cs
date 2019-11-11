using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartNotification
    {
        public int PartNotificationId { get; set; }
        public int PartNotificationNotificationId { get; set; }
        public int PartNotificationPartId { get; set; }

        public virtual StockingNotification PartNotificationNotification { get; set; }
        public virtual Part PartNotificationPart { get; set; }
    }
}
