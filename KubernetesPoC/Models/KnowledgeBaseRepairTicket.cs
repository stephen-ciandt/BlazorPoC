using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseRepairTicket
    {
        public int KnowledgeBaseRepairTicketId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int RepairTicketId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
        public virtual RepairTicket RepairTicket { get; set; }
    }
}
