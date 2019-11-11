using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class DeliveryRequestNotification
    {
        public int DeliveryRequestNotificationId { get; set; }
        public int DeliveryRequestId { get; set; }
        public int StockingNotificationId { get; set; }

        public virtual DeliveryRequest DeliveryRequest { get; set; }
        public virtual StockingNotification StockingNotification { get; set; }
    }
}
