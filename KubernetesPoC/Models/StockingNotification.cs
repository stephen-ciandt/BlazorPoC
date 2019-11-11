using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class StockingNotification
    {
        public StockingNotification()
        {
            CycleCountNotification = new HashSet<CycleCountNotification>();
            DeliveryRequestNotification = new HashSet<DeliveryRequestNotification>();
            PartNotification = new HashSet<PartNotification>();
            StockingNotificationUser = new HashSet<StockingNotificationUser>();
            UserCertNotificationMapping = new HashSet<UserCertNotificationMapping>();
        }

        public int StockingNotificationId { get; set; }
        public int NotificationType { get; set; }
        public int Status { get; set; }
        public long CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public long? ModifiedDate { get; set; }

        public virtual ICollection<CycleCountNotification> CycleCountNotification { get; set; }
        public virtual ICollection<DeliveryRequestNotification> DeliveryRequestNotification { get; set; }
        public virtual ICollection<PartNotification> PartNotification { get; set; }
        public virtual ICollection<StockingNotificationUser> StockingNotificationUser { get; set; }
        public virtual ICollection<UserCertNotificationMapping> UserCertNotificationMapping { get; set; }
    }
}
