using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicketHistory
    {
        public int RepairTicketHistoryId { get; set; }
        public int RepairTicketHistoryRepairTicketId { get; set; }
        public int RepairTicketHistoryFromState { get; set; }
        public int RepairTicketHistoryToState { get; set; }
        public int RepairTicketHistoryInitiatedByUserId { get; set; }
        public long RepairTicketHistoryInitiatedDate { get; set; }

        public virtual User RepairTicketHistoryInitiatedByUser { get; set; }
        public virtual RepairTicket RepairTicketHistoryRepairTicket { get; set; }
    }
}
