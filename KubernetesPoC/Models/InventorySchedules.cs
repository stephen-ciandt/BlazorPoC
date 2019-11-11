using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class InventorySchedules
    {
        public int InventoryScheduleId { get; set; }
        public long? InventoryScheduleEveryNthTime { get; set; }
        public int InventoryScheduleRecurrenceType { get; set; }
        public int? InventoryScheduleWeeklyDay { get; set; }
        public int? InventoryScheduleMonthlyDate { get; set; }
        public int? InventoryScheduleYearlyMonth { get; set; }
        public int? InventoryScheduleYearlyDay { get; set; }
        public long? InventoryScheduleFirstDue { get; set; }
        public long InventoryScheduleCycleCountTmplld { get; set; }
        public long? InventoryScheduleCurrentDueDate { get; set; }
        public int? InventoryScheduleEndBy { get; set; }
        public int InventoryScheduleScheduleTimeOfDay { get; set; }
        public int? InventoryScheduleCreatedUser { get; set; }
        public long? InventoryScheduleCreatedDate { get; set; }
        public bool InventoryScheduleIsDeleted { get; set; }
        public int? InventoryScheduleLastUpdatedBy { get; set; }
        public long? InventoryScheduleLastUpdatedTimeStamp { get; set; }

        public virtual User InventoryScheduleCreatedUserNavigation { get; set; }
        public virtual CycleCount InventoryScheduleCycleCountTmplldNavigation { get; set; }
        public virtual User InventoryScheduleLastUpdatedByNavigation { get; set; }
    }
}
