using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MaintenanceOrderTemplateAttribute
    {
        public int MaintenanceOrderTemplateAttributeId { get; set; }
        public int MaintenanceOrderTemplateAttributeAttributeId { get; set; }
        public int MaintenanceOrderTemplateAttributeMaintenanceId { get; set; }
        public string MaintenanceOrderTemplateAttributeValue { get; set; }

        public virtual Attribute MaintenanceOrderTemplateAttributeAttribute { get; set; }
        public virtual MaintenanceOrderTemplate MaintenanceOrderTemplateAttributeMaintenance { get; set; }
    }
}
