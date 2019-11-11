using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartDelivery
    {
        public int PartDeliveryId { get; set; }
        public int PartId { get; set; }
        public int DeliveryRequestId { get; set; }
        public int LocationId { get; set; }
        public double RequestedQuantity { get; set; }
        public double DeliveredQuantity { get; set; }

        public virtual DeliveryRequest DeliveryRequest { get; set; }
        public virtual Location Location { get; set; }
        public virtual Part Part { get; set; }
    }
}
