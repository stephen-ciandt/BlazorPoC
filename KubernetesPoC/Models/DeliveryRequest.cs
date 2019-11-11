using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class DeliveryRequest
    {
        public DeliveryRequest()
        {
            DeliveryRequestNotification = new HashSet<DeliveryRequestNotification>();
            PartDelivery = new HashSet<PartDelivery>();
        }

        public int DeliveryRequestId { get; set; }
        public int MaintenanceOrderId { get; set; }
        public int Status { get; set; }
        public long RequestDate { get; set; }
        public int ResquestedBy { get; set; }
        public long? DeliveryDate { get; set; }
        public int? ReasonCodeId { get; set; }
        public string ReasonCodeDescription { get; set; }
        public int? DeliveredBy { get; set; }

        public virtual User DeliveredByNavigation { get; set; }
        public virtual MaintenanceOrder MaintenanceOrder { get; set; }
        public virtual User ResquestedByNavigation { get; set; }
        public virtual ICollection<DeliveryRequestNotification> DeliveryRequestNotification { get; set; }
        public virtual ICollection<PartDelivery> PartDelivery { get; set; }
    }
}
