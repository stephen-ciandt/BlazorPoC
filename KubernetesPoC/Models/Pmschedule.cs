using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Pmschedule
    {
        public Pmschedule()
        {
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            PmscheduleEquipmentNavigation = new HashSet<PmscheduleEquipment>();
        }

        public int PmscheduleId { get; set; }
        public double? PmscheduleEveryNthTime { get; set; }
        public int PmscheduleRecurrenceType { get; set; }
        public int? PmscheduleWeeklyDay { get; set; }
        public int? PmscheduleMonthlyDate { get; set; }
        public int? PmscheduleYearlyMonth { get; set; }
        public long PmscheduleFirstDue { get; set; }
        public int? PmscheduleEquipmentId { get; set; }
        public int? PmscheduleMoTemplateId { get; set; }
        public long? PmscheduleCurrentMaintenanceOrderDueDate { get; set; }
        public long PmscheduleCreatedDate { get; set; }
        public int? PmScheduleYearlyDay { get; set; }
        public long? PmScheduleEndBy { get; set; }
        public int? PmScheduleScheduleTimeOfDay { get; set; }
        public bool? PmscheduleIsActive { get; set; }
        public int? PmscheduleCreatedUser { get; set; }
        public int? PmscheduleMeterId { get; set; }
        public double? PmscheduleMinThreshold { get; set; }
        public double? PmscheduleMaxThreshold { get; set; }
        public double? PmscheduleNextDueMeter { get; set; }
        public bool? PmscheduleMeterReset { get; set; }
        public bool PmscheduleIsAutoTag { get; set; }
        public int PmscheduleControlFlag { get; set; }
        public bool PmscheduleIsDeleted { get; set; }
        public Guid? PmscheduleReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public string PmscheduleGroupName { get; set; }
        public int? PmscheduleAreaId { get; set; }

        public virtual Area PmscheduleArea { get; set; }
        public virtual User PmscheduleCreatedUserNavigation { get; set; }
        public virtual Equipment PmscheduleEquipment { get; set; }
        public virtual MaintenanceOrderTemplate PmscheduleMoTemplate { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<PmscheduleEquipment> PmscheduleEquipmentNavigation { get; set; }
    }
}
