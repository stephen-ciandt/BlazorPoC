using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ReasonCode
    {
        public ReasonCode()
        {
            CycleCount = new HashSet<CycleCount>();
            MaintenanceOrderMaintenanceOrderCancelReasonCode = new HashSet<MaintenanceOrder>();
            MaintenanceOrderMaintenanceOrderReasonCode = new HashSet<MaintenanceOrder>();
            MaintenanceOrderTemplate = new HashSet<MaintenanceOrderTemplate>();
            ReasonCodeGroupMembers = new HashSet<ReasonCodeGroupMembers>();
            RepairTicketRepairTicketCancelReasonCode = new HashSet<RepairTicket>();
            RepairTicketRepairTicketFailureCode = new HashSet<RepairTicket>();
            RepairTicketTemplate = new HashSet<RepairTicketTemplate>();
        }

        public int ReasonCodeId { get; set; }
        public string ReasonCodeName { get; set; }
        public string ReasonCodeDescription { get; set; }
        public string ReasonCodeCreatedBy { get; set; }
        public long ReasonCodeCreatedDate { get; set; }
        public int? Type { get; set; }
        public int ReasonCodeControlFlag { get; set; }
        public bool ReasonCodeIsDeleted { get; set; }
        public Guid? ReasonCodeReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<CycleCount> CycleCount { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrderMaintenanceOrderCancelReasonCode { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrderMaintenanceOrderReasonCode { get; set; }
        public virtual ICollection<MaintenanceOrderTemplate> MaintenanceOrderTemplate { get; set; }
        public virtual ICollection<ReasonCodeGroupMembers> ReasonCodeGroupMembers { get; set; }
        public virtual ICollection<RepairTicket> RepairTicketRepairTicketCancelReasonCode { get; set; }
        public virtual ICollection<RepairTicket> RepairTicketRepairTicketFailureCode { get; set; }
        public virtual ICollection<RepairTicketTemplate> RepairTicketTemplate { get; set; }
    }
}
