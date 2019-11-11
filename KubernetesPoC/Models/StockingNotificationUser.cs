using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class StockingNotificationUser
    {
        public int StockingNotificationUserId { get; set; }
        public int StockingNotificationId { get; set; }
        public int UserId { get; set; }
        public int UserActionStatus { get; set; }

        public virtual StockingNotification StockingNotification { get; set; }
        public virtual User User { get; set; }
    }
}
