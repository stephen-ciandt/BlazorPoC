using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicketComment
    {
        public int RepairTicketCommentId { get; set; }
        public string RepairTicketCommentComment { get; set; }
        public string RepairTicketCommentFileName { get; set; }
        public int RepairTicketCommentCommentAddedByUserId { get; set; }
        public int RepairTicketCommentRepairTicketId { get; set; }
        public long RepairTicketCommentCommentCreatedDate { get; set; }

        public virtual User RepairTicketCommentCommentAddedByUser { get; set; }
        public virtual RepairTicket RepairTicketCommentRepairTicket { get; set; }
    }
}
