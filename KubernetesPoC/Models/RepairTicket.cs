using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicket
    {
        public RepairTicket()
        {
            KnowledgeBaseRepairTicket = new HashSet<KnowledgeBaseRepairTicket>();
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            MoRepairRequests = new HashSet<MoRepairRequests>();
            RepairTicketClosedNotification = new HashSet<RepairTicketClosedNotification>();
            RepairTicketComment = new HashSet<RepairTicketComment>();
            RepairTicketHistory = new HashSet<RepairTicketHistory>();
        }

        public int RepairTicketId { get; set; }
        public int? RepairTicketPriority { get; set; }
        public string RepairTicketNumber { get; set; }
        public int RepairTicketFailureCodeId { get; set; }
        public string RepairTicketTitle { get; set; }
        public long RepairTicketIncidentDate { get; set; }
        public int RepairTicketStatus { get; set; }
        public string RepairTicketDescription { get; set; }
        public int RepairTicketEquipmentId { get; set; }
        public long RepairTicketFailureDate { get; set; }
        public int? RepairTicketCancelReasonCodeId { get; set; }
        public int RepairTicketReportedByUserId { get; set; }
        public long RepairTicketCreatedDate { get; set; }
        public long? RepairTicketClosedDate { get; set; }
        public Guid? RepairTicketReferenceId { get; set; }
        public string RepairTicketOriginator { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int? RepairTicketBusinessRuleId { get; set; }

        public virtual ReasonCode RepairTicketCancelReasonCode { get; set; }
        public virtual Equipment RepairTicketEquipment { get; set; }
        public virtual ReasonCode RepairTicketFailureCode { get; set; }
        public virtual User RepairTicketReportedByUser { get; set; }
        public virtual ICollection<KnowledgeBaseRepairTicket> KnowledgeBaseRepairTicket { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<MoRepairRequests> MoRepairRequests { get; set; }
        public virtual ICollection<RepairTicketClosedNotification> RepairTicketClosedNotification { get; set; }
        public virtual ICollection<RepairTicketComment> RepairTicketComment { get; set; }
        public virtual ICollection<RepairTicketHistory> RepairTicketHistory { get; set; }
    }
}
