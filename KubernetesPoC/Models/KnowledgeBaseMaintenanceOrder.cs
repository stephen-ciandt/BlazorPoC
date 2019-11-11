using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseMaintenanceOrder
    {
        public int KnowledgeBaseMaintenanceOrderId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int MaintenanceOrderId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
        public virtual MaintenanceOrder MaintenanceOrder { get; set; }
    }
}
