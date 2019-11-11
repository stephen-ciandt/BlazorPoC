using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class FeederMonitor
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentSerialNumber { get; set; }
        public string RepairTicketNumber { get; set; }
        public string MaintenanceOrderNumber { get; set; }
        public string AlertOverallStatus { get; set; }
        public string RepairTicketTitle { get; set; }
        public string MaintenanceOrderTitle { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public int? AreaEquipmentMembersSequenceNumber { get; set; }
        public string ReasonCodeName { get; set; }
        public string MaintenanceEventTypeName { get; set; }
        public string EquipmentMachineCounter { get; set; }
        public long? MaintenanceOrderScheduledDate { get; set; }
        public long? MaintenanceOrderPlannedDueDate { get; set; }
        public long MoResourcesScanOnDateTime { get; set; }
        public string NozzleType { get; set; }
        public string NozzleSize { get; set; }
        public string TotalPickupCount { get; set; }
        public int Type { get; set; }
        public int EquipmentSubType { get; set; }
        public long? TimeScheduledDueDate { get; set; }
        public string TicketsDisplayed { get; set; }
        public string EquipmentMeterName { get; set; }
        public decimal? HiddenTimeTillSchedDate { get; set; }
        public long? Ordercol { get; set; }
    }
}
