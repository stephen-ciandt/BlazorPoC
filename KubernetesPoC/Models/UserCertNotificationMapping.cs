using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertNotificationMapping
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public int? CertificationResultId { get; set; }
        public int CertificationId { get; set; }

        public virtual UserCertificationList Certification { get; set; }
        public virtual UserCertificationResults CertificationResult { get; set; }
        public virtual StockingNotification Notification { get; set; }
        public virtual User User { get; set; }
    }
}
