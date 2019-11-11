using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCountNotification
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public long CycleCountId { get; set; }

        public virtual CycleCount CycleCount { get; set; }
        public virtual StockingNotification Notification { get; set; }
    }
}
