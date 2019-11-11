using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoParts
    {
        public int MoPartsId { get; set; }
        public decimal? MoPartsQuantityNeeded { get; set; }
        public int MoPartsPartId { get; set; }
        public int MoPartsUnitOfMeasureId { get; set; }
        public decimal? MoPartsQuantityUsed { get; set; }
        public int MoPartsMaintenanceOrderId { get; set; }
        public int? MoPartsPartUsedByUserId { get; set; }
        public int MoPartsAreaId { get; set; }
        public int MoPartsLocationId { get; set; }
        public int? MoPartsSubLocationId { get; set; }
        public int? MoPartsBinNo { get; set; }

        public virtual MaintenanceOrder MoPartsMaintenanceOrder { get; set; }
        public virtual Part MoPartsPart { get; set; }
        public virtual User MoPartsPartUsedByUser { get; set; }
        public virtual UnitOfMeasure MoPartsUnitOfMeasure { get; set; }
    }
}
