using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicketTemplateClosedNotification
    {
        public int RepairTicketTemplateClosedNotificationId { get; set; }
        public int RepairTicketTemplateClosedNotificationUserId { get; set; }
        public int RepairTicketTemplateClosedNotificationRepairTicketTemplateId { get; set; }

        public virtual RepairTicketTemplate RepairTicketTemplateClosedNotificationRepairTicketTemplate { get; set; }
        public virtual User RepairTicketTemplateClosedNotificationUser { get; set; }
    }
}
