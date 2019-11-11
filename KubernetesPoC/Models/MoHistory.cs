using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoHistory
    {
        public int MoHistoryId { get; set; }
        public int MoHistoryMaintenanceOrderId { get; set; }
        public int MoHistoryFromState { get; set; }
        public int MoHistoryToState { get; set; }
        public int MoHistoryInitiatedByUserId { get; set; }
        public long MoHistoryInitiatedDate { get; set; }

        public virtual User MoHistoryInitiatedByUser { get; set; }
        public virtual MaintenanceOrder MoHistoryMaintenanceOrder { get; set; }
    }
}
