using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AuditNotificationUser
    {
        public int AuditNotificationUserId { get; set; }
        public int AuditNotificationId { get; set; }
        public int UserId { get; set; }
        public int UserActionStatus { get; set; }

        public virtual AuditNotification AuditNotification { get; set; }
        public virtual User User { get; set; }
    }
}
