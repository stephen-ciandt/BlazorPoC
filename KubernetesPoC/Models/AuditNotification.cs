using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AuditNotification
    {
        public AuditNotification()
        {
            AuditNotificationUser = new HashSet<AuditNotificationUser>();
        }

        public int AuditNotificationId { get; set; }
        public int NotificationType { get; set; }
        public int Status { get; set; }
        public long CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public long? ModifiedDate { get; set; }

        public virtual ICollection<AuditNotificationUser> AuditNotificationUser { get; set; }
    }
}
