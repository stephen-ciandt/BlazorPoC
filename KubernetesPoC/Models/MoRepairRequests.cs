using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoRepairRequests
    {
        public int MoRepairRequestsId { get; set; }
        public int MoRepairRequestsMaintenanceOrderId { get; set; }
        public int MoRepairRequestsRepairRequestId { get; set; }

        public virtual MaintenanceOrder MoRepairRequestsMaintenanceOrder { get; set; }
        public virtual RepairTicket MoRepairRequestsRepairRequest { get; set; }
    }
}
