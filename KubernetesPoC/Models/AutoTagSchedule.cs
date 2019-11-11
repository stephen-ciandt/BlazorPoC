using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AutoTagSchedule
    {
        public int AutoTagScheduleId { get; set; }
        public int? AutoTagScheduleEveryNthTime { get; set; }
        public int AutoTagScheduleRecurrenceType { get; set; }
        public int? AutoTagScheduleWeeklyDay { get; set; }
        public int? AutoTagScheduleMonthlyDate { get; set; }
        public int? AutoTagScheduleYearlyMonth { get; set; }
        public long? AutoTagScheduleFirstDue { get; set; }
        public int AutoTagScheduleEquipmentId { get; set; }
        public int AutoTagScheduleMoTemplateId { get; set; }
        public long? AutoTagScheduleCurrentMaintenanceOrderDueDate { get; set; }
        public long AutoTagScheduleCreatedDate { get; set; }
        public int? AutoTagScheduleYearlyDay { get; set; }
        public long? AutoTagScheduleEndBy { get; set; }
        public int? AutoTagScheduleScheduleTimeOfDay { get; set; }
        public int? AutoTagScheduleCreatedUser { get; set; }
        public bool? AutoTagScheduleIsActive { get; set; }
        public int AutoTagScheduleControlFlag { get; set; }
        public bool AutoTagScheduleIsDeleted { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual User AutoTagScheduleCreatedUserNavigation { get; set; }
        public virtual Equipment AutoTagScheduleEquipment { get; set; }
        public virtual MaintenanceOrderTemplate AutoTagScheduleMoTemplate { get; set; }
    }
}
