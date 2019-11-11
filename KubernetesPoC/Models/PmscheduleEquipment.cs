using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PmscheduleEquipment
    {
        public int PmscheduleEquipmentId { get; set; }
        public int PmscheduleEquipmentScheduleId { get; set; }
        public int PmscheduleEquipmentEquipmentId { get; set; }
        public int PmscheduleEquipmentMoTemplateId { get; set; }
        public long? PmscheduleEquipmentCurrentMaintenanceOrderDueDate { get; set; }

        public virtual Equipment PmscheduleEquipmentEquipment { get; set; }
        public virtual MaintenanceOrderTemplate PmscheduleEquipmentMoTemplate { get; set; }
        public virtual Pmschedule PmscheduleEquipmentSchedule { get; set; }
    }
}
