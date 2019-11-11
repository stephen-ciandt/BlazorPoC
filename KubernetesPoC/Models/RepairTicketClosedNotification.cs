using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicketClosedNotification
    {
        public int RepairTicketClosedNotificationId { get; set; }
        public int RepairTicketClosedNotificationUserId { get; set; }
        public int RepairTicketClosedNotificationRepairTicketId { get; set; }

        public virtual RepairTicket RepairTicketClosedNotificationRepairTicket { get; set; }
        public virtual User RepairTicketClosedNotificationUser { get; set; }
    }
}
