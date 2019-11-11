using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicketSummary
    {
        public int RepairTicketSummaryId { get; set; }
        public int? RepairTicketSummaryEquipmentId { get; set; }
        public string RepairTicketSummaryEquipmentName { get; set; }
        public string RepairTicketSummaryMaintenanceOrderNumber { get; set; }
        public string RepairTicketSummaryRepairTicketNumber { get; set; }
        public int? RepairTicketSummaryAreaId { get; set; }
        public string RepairTicketSummaryAreaName { get; set; }
        public long? RepairTicketSummaryCreatedDate { get; set; }
        public long? RepairTicketSummaryClosedDate { get; set; }
        public long? RepairTicketSummaryCalendarDate { get; set; }
        public int? RepairTicketSummaryTotalTimeInMin { get; set; }
        public int? RepairTicketSummaryDownTimeInMin { get; set; }

        public virtual Area RepairTicketSummaryArea { get; set; }
        public virtual Equipment RepairTicketSummaryEquipment { get; set; }
    }
}
