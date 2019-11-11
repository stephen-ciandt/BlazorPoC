using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CostCenter
    {
        public CostCenter()
        {
            CycleCountAssets = new HashSet<CycleCountAssets>();
            Equipment = new HashSet<Equipment>();
            EquipmentCostCenterHistory = new HashSet<EquipmentCostCenterHistory>();
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            MaintenanceOrderTemplate = new HashSet<MaintenanceOrderTemplate>();
        }

        public int CostCenterId { get; set; }
        public string CostCenterName { get; set; }
        public string CostCenterDescription { get; set; }
        public int CostCenterControlFlag { get; set; }
        public bool CostCenterIsDeleted { get; set; }
        public Guid? CostCenterReferenceId { get; set; }

        public virtual ICollection<CycleCountAssets> CycleCountAssets { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<EquipmentCostCenterHistory> EquipmentCostCenterHistory { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<MaintenanceOrderTemplate> MaintenanceOrderTemplate { get; set; }
    }
}
