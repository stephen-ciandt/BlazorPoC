using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MaintenanceOrderAttribute
    {
        public int MaintenanceOrderAttributeId { get; set; }
        public int MaintenanceOrderAttributeAttributeId { get; set; }
        public int MaintenanceOrderAttributeMaintenanceId { get; set; }
        public string MaintenanceOrderAttributeValue { get; set; }

        public virtual Attribute MaintenanceOrderAttributeAttribute { get; set; }
        public virtual MaintenanceOrder MaintenanceOrderAttributeMaintenance { get; set; }
    }
}
