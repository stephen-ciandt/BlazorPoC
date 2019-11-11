using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MaintenanceEventType
    {
        public MaintenanceEventType()
        {
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            MaintenanceOrderTemplate = new HashSet<MaintenanceOrderTemplate>();
        }

        public int MaintenanceEventTypeId { get; set; }
        public string MaintenanceEventTypeName { get; set; }
        public string MaintenanceEventTypeDescription { get; set; }
        public int MaintenanceEventTypeControlFlag { get; set; }
        public bool MaintenanceEventTypeIsDeleted { get; set; }
        public Guid? MaintenanceEventTypeReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<MaintenanceOrderTemplate> MaintenanceOrderTemplate { get; set; }
    }
}
